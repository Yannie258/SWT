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
using SpeechLib;
namespace PersonalDictionary
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            loadDataToListbox();
        }
        private void loadDataToListbox()
        {
            try
            {
                //load Items von Database to Listbox
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
        private void btnLookup_Click(object sender, EventArgs e)
        {
            try
            {
                string german = txbSearch.Text;
                // gefundene Wort wurde in einem temperatoren Table und in Textbox anzeigen
                DataTable dt = SqlHelper.SqlHelper.ExecuteDataset(SQLdata.sql, "Lookup_dict", german).Tables[0];
                // testen, ob diese Worte in Datenbank existiert
                if (dt.Rows.Count > 0)
                {
                    txbMean.Text = dt.Rows[0]["VNShort"].ToString();
                    txbDetail.Text = dt.Rows[0]["VNLong"].ToString();
                }
                else
                {
                    MessageBox.Show("not exists in Database!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void lbItem_Click(object sender, EventArgs e)
        {
            try
            {
                //temp enthaelt Item, wenn User das clickt
                string temp = lbItem.Text;
                //ID Wert nach German->muss noch ein Store erzeugen um zu verweisen
                DataTable dt = SqlHelper.SqlHelper.ExecuteDataset(SQLdata.sql, "Lookup_dict",temp).Tables[0];
                txbSearch.Text = temp;
                if (dt.Rows.Count > 0)
                {
                    txbMean.Text = dt.Rows[0]["VNShort"].ToString();
                    txbDetail.Text = dt.Rows[0]["VNLong"].ToString();
                }
                else
                {
                    MessageBox.Show("Data empty!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        

        private void btnSpeaker_Click(object sender, EventArgs e)
        {
            SpVoice speak = new SpVoice();
            speak.Speak(txbSearch.Text, SpeechVoiceSpeakFlags.SVSFDefault);
        }

        private void spkmean_Click(object sender, EventArgs e)
        {
            SpVoice speak_m = new SpVoice();
            speak_m.Speak(txbMean.Text, SpeechVoiceSpeakFlags.SVSFDefault);
        }

        private void spkdetail_Click(object sender, EventArgs e)
        {
            SpVoice speak_d = new SpVoice();
            speak_d.Speak(txbDetail.Text, SpeechVoiceSpeakFlags.SVSFDefault);
        }

       
        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to close the Program?", "", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }
    }
}
