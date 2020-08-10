using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ApplicationBlocks.Data;

namespace PersonalDictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

       
       
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Wenn man nur searchen moechte, zeigt direkt an
            MainForm _main = new MainForm();
            _main.Show();
            this.Hide();//Haupt Fenster wird geschwunden, kommt nur neues Fenster danach
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            //Wenn man Adminitritor sei, kann man hier Add, Delete, Alter Datei
            //der muss einloggen, um Data zuzugreifen
            LoginGrpBox.Show();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //Login Button steuern
            //wenn User einlogt, wuerde es mit Database vergleichen
            //wenn user und passwort gleich sind -> Management Form
            // sonst ein Warnungnachricht anzeigen
            string user = txb_usr.Text;
            string pass = txb_pass.Text;
            // ein Table, der Parameter user und pass enthaelt, erzeugt
            //Struktur von SQLHelper (Connectstring,Producename,Parameter(s))
            //und StoreProduce in DB Query
            DataTable dt = SqlHelper.SqlHelper.ExecuteDataset(SQLdata.str, "Login_Select", user, pass).Tables[0];
            //Wenn User richtig eingibt
            //Management Form angezeigt wird 
            if (dt.Rows.Count > 0)
            {
                ManagementData md = new ManagementData();
                md.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User und Password nicht korrect! ");
            }
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
