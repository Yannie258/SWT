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
using PersonalDictionary.DataController;
using PersonalDictionary.Model;
using PersonalDictionary.Controller;

namespace PersonalDictionary
{
    public partial class Start : Form
    {
       
        public Start()
        {
            InitializeComponent();
        }
        
        UserController uc = new UserController();
        //Event Button Search
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Wenn man nur searchen moechte, zeigt direkt an
            //MainForm _main = new MainForm();
            //_main.Show();
            uc.Search();
            this.Hide();//Haupt Fenster wird geschwunden, kommt nur neues Fenster danach
        }

        //Event Button Management
        private void btnManagement_Click(object sender, EventArgs e)
        {
            //Wenn man Adminitritor sei, kann man hier Add, Delete, Alter Datei
            //der muss einloggen, um Data zuzugreifen
            LoginGrpBox.Show();
        }
        /* Event loggin Button:
         * wenn User einlogt, wuerde es mit Database vergleichen
         * wenn user und passwort gleich sind -> Management Form
         * sonst ein Warnungnachricht anzeigen
          */
        private void btn_Login_Click(object sender, EventArgs e)
        {
           
            string user = txb_usr.Text;
            string pass = txb_pass.Text;
            
            // ein leeres Table, der Parameter user und pass enthaelt, erzeugt
            /*Struktur von SQLHelper (Connectstring,Procedurename,Parameter(s))
             * und StoreProduce in DB Query
             * SQLHelper- Hilfklasse, darin es sich wiedeholende Code konsolidieren
             * stattdessen: 
             * SqlConnection con = new SqlConnection();
             * SqlCommand cmd = new SqlCommand();
             * ...
             * try catch -> Exception fangen, wenn Verbindung mit Database nicht errreicht
             * */
            
            DataTable dt = SqlHelper.SqlHelper.ExecuteDataset(SQLdata.sql, "Login_Select", user, pass).Tables[0];
            try
            {
                //Wenn User richtig eingibt
                //Management Form angezeigt wird 
                if (dt.Rows.Count > 0)
                {
                    //ManagementData md = new ManagementData();
                    //md.Show();
                    uc.ShowManagement();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("User und Password nicht korrect! ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Wenn User Kreuze Knoten oben rechts des Formes , werden ein Confirm Message anzeigen 
        private void Start_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to close it?","", MessageBoxButtons.YesNo)!= DialogResult.OK)
            {
                e.Cancel = true; //close form
            } 


        }

        
    }
}
