using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ApplicationBlocks.Data;
using PersonalDictionary.Model;
using SpeechLib;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;
using DarrenLee.SpeechSynthesis;
using PersonalDictionary.Controller;

namespace PersonalDictionary
{
    public partial class MainForm : Form
    {
        // SpeakText Vietnam;
        //SpeechSynthesizer speech;
        public MainForm()
        {
            InitializeComponent();     
        }
        //DictionarySearchModel dm = new DictionarySearchModel();
        ControlSearch cs = new ControlSearch();


        //wenn MainForm geoefnet ist, werden Data in ListBox auch geloadet (WordList anzeigen)
        #region

        private void MainForm_Load(object sender, EventArgs e)
        {
            lbItem.DataSource = cs.Load();
            loadDataToListbox();
            
        }
        private void loadDataToListbox()
        {
            try
            {
                //load Items von Database to Listbox
                //Table select_dict in Store Procedure von Datenbank abgespeichert.
                //(e. SQLQuery) davon werde es den Befehl: select * from <DBname> erzeugen
                DataTable dt = SqlHelper.SqlHelper.ExecuteDataset(SQLdata.sql, "select_dict").Tables[0];
                lbItem.DataSource = dt;
                lbItem.DisplayMember = "German";
                lbItem.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        //Event Load Data from ItemList to Textbox
        #region
        private void lbItem_Click(object sender, EventArgs e)
        {
            //temp enthaelt Item, wenn User das clickt
            string temp = lbItem.Text;
            //ID Wert nach German->muss noch ein Store erzeugen um zu verweisen
            DataTable dt = SqlHelper.SqlHelper.ExecuteDataset(SQLdata.sql, "Lookup_dict", temp).Tables[0];
            try
            {
                txbSearch.Text = temp;
                //wenn es gefunden ist, wird es in TextBox als Zeichenkettetyp angezeigt
                if (dt.Rows.Count > 0)
                {
                    txbMean.Text = dt.Rows[0]["VNShort"].ToString();
                    txbDetail.Text = dt.Rows[0]["VNLong"].ToString();
                }
                // wenn nicht gefunden
                else
                {
                    MessageBox.Show("Data empty!");
                }
            }
            //falls es Fehler im Datenbank gibt
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion
        //Event Button Search German
        private void btnLookup_Click(object sender, EventArgs e)
        {
            string german = txbSearch.Text;
            string mean = txbMean.Text;
            string detail = txbDetail.Text;
            // gefundene Wort wurde in einem temperatoren Table und in Textbox anzeigen
           // DataTable dt = SqlHelper.SqlHelper.ExecuteDataset(SQLdata.sql, "Lookup_dict", german).Tables[0];
            
            try 
            {      // testen, ob diese Worte in Datenbanktable existiert   
                bool prep = cs.SearchGerman(txbSearch.Text, txbMean.Text, txbDetail.Text);
                if(prep == true)
                {

                }

                //if (dt.Rows.Count > 0)
                //{
                //  txbMean.Text = dt.Rows[0]["VNShort"].ToString();
                // txbDetail.Text = dt.Rows[0]["VNLong"].ToString();
                //}
                //else
                //{
                //    MessageBox.Show("Not exists in WordList. You should create new one!");
                //}
            }
            catch // (Exception ex)//catch Error from Datenbank
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Not exists in WordList. You should create new one!");
            }

        }


        //private void spkmean_Click(object sender, EventArgs e)
        //{
        //    SpVoice speak_m = new SpVoice();
        //    speak_m.Speak(txbMean.Text, SpeechVoiceSpeakFlags.SVSFDefault);
        //}                

        private void btnLookup_back_Click(object sender, EventArgs e)
        {
            try
            {
                string mean = txbMean.Text;
                // gefundene Wort wurde in einem temperatoren Table und in Textbox anzeigen
                DataTable dt = SqlHelper.SqlHelper.ExecuteDataset(SQLdata.sql, "Lookup_back", mean).Tables[0];
                // testen, ob diese Worte in Datenbank existiert
                if (dt.Rows.Count > 0)
                {
                    txbSearch.Text = dt.Rows[0]["German"].ToString();
                    txbDetail.Text = dt.Rows[0]["VNLong"].ToString();
                }
                else
                {
                    MessageBox.Show("Not exists in WordList. You should create new one!");
                }
            }
            catch (Exception ex)//catch Error from System
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*Wenn User im Textbox klickt, werden passenden Button erleuchten 
         * */
        #region
        public void setButtonSearchGerman()
        {
            btnLookup_back.Enabled = false;
            btnLookup.Enabled = true;
        }
        public void setButtonSearchMean()
        {
            btnLookup_back.Enabled = true;
            btnLookup.Enabled = false;
        }
        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            setButtonSearchGerman();
        }

        private void txbMean_TextChanged(object sender, EventArgs e)
        {
            setButtonSearchMean();
        }

        #endregion

        //German pronounciation Button
        //Liest Data in Textbox German vor
        private void btnSpeaker_Click(object sender, EventArgs e)
        {
            SpVoice speak = new SpVoice();
            speak.Speak(txbSearch.Text, SpeechVoiceSpeakFlags.SVSFDefault);
        }

        //zurueck zum Login Form Button
        private void btnBack_Click(object sender, EventArgs e)
        {
            cs.s_back();
            this.Close();
        }
    }
}
