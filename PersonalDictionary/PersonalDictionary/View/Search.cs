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
        #region Load to ListBox
       
       

        private void MainForm_Load(object sender, EventArgs e)
        {
            //nur German visible
            //load Items von Database to Listbox
            setButtonLoadData();
            try
            {
                //Verweisen mit Controller Objekt
                DataTable dt = cs.LoadDataTable();
                //nur Deutsch in ListBox
                Column column = Column.German;
                // Table select_dict in Store Procedure von Datenbank abgespeichert.
                lbItem.DataSource = dt;
                lbItem.DisplayMember = column.ToString();
                //Suchen Button deaktiviert wenn User nicht in TextBox schreibt
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//Verbindung mit Database Fehler 
            }

        }
       
        #endregion

        //Event Load Data from ItemList to Textbox
        #region Load to Textbox
        private void lbItem_Click(object sender, EventArgs e)
        {
            setButtonLoadData();
            //temp enthaelt Item, wenn User an ListBox clickt, werden Data in TextBox ausgezeigt
            //DataTable dt = SqlHelper.SqlHelper.ExecuteDataset(SQLdata.sql, "Lookup_dict", temp).Tables[0];
            DataTable dt = cs.LoadDataToTextBox(lbItem.Text);
            try
            {
            //    txbSearch.Text = temp;
            //    //wenn es gefunden ist, wird es in TextBox als Zeichenkettetyp angezeigt
                if (dt.Rows.Count > 0)
                {
                    txbSearch.Text = dt.Rows[0][Column.German.ToString()].ToString();
                    txbMean.Text = dt.Rows[0][Column.VNShort.ToString()].ToString();
                    txbDetail.Text = dt.Rows[0][Column.VNLong.ToString()].ToString();
                }
            
           
            }
            //falls es Fehler im Datenbank gibt
            catch (Exception)
            {
                MessageBox.Show("Error DataSystemConnection");
            }

        }
        #endregion
        //Event Button Search German
        #region Vietnamese Searching
        private void btnLookup_Click(object sender, EventArgs e)
        {
            //Suchen nach Deutsch
            string german = txbSearch.Text;
            //Verweisen zum VNMean und Details Column
            string mean = Column.VNShort.ToString();
            string detail = Column.VNLong.ToString();
            //rufen in Proc Lookup_dict ab
            DataTable re=cs.SearchVNFromGerman(SQLdata.sql,TableProcedure.Lookup_dict.ToString(), german);
            try
            {
                if (re != null) //wenn ein Ergebnis gefunden ist, zeigt die Bedeutungen und Kontext
                {
                    txbMean.Text = re.Rows[0][mean].ToString();
                    txbDetail.Text = re.Rows[0][detail].ToString();
                }
                else
                {
                    MessageBox.Show("Not found. That word are still not be created !");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Error DataSystemConnection");
            }
        }
        #endregion

        //private void spkmean_Click(object sender, EventArgs e)
        //{
        //    SpVoice speak_m = new SpVoice();
        //    speak_m.Speak(txbMean.Text, SpeechVoiceSpeakFlags.SVSFDefault);
        //}                
        #region German Searching
        private void btnLookup_back_Click(object sender, EventArgs e)
        {
            //Suchen nach Vietnamese
            //funktunieren aehnlich wie oben
            //nur anderen Procedure und Spalten
            string viet = txbMean.Text;
            string germ = Column.German.ToString();
            string detail = Column.VNLong.ToString();
            DataTable re = cs.SearchVNFromGerman(SQLdata.sql,TableProcedure.Lookup_back.ToString(),viet);
            try
            {
                if (re != null)
                {
                    //Deutsch und Detail anzeigen
                    txbSearch.Text = re.Rows[0][germ].ToString();
                    txbDetail.Text = re.Rows[0][detail].ToString();
                }
                else
                {
                    MessageBox.Show("That word are still not created !");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("System Error!");
            }
           
        }
        #endregion
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
        public void setButtonLoadData()
        {
            btnLookup_back.Enabled = false;
            btnLookup.Enabled = false;
        }
        //deaktiviert Search Vietnamese Button, wenn Deucht sucht  
        private void txbSearch_TextChanged(object sender, EventArgs e)
        {

            setButtonSearchGerman();
        }
        //deaktiviert Search Deutsch Button, wenn Vietnamese sucht  

        private void txbMean_TextChanged(object sender, EventArgs e)
        {
            setButtonSearchMean();
        }

        #endregion

        //German pronounciation Button
        //Liest Wort in Textbox German vor
        private void btnSpeaker_Click(object sender, EventArgs e)
        {
            SpVoice speak = new SpVoice();
            speak.Speak(txbSearch.Text, SpeechVoiceSpeakFlags.SVSFDefault);
        }

        //zurueck zum Start Form Button
        private void btnBack_Click(object sender, EventArgs e)
        {
            //cs.s_back();
            //this.Close();
            Start start = new Start();
            start.Show();
            this.Hide();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
