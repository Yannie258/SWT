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
//using PersonalDictionary.DataController;

using PersonalDictionary.Controller;

namespace PersonalDictionary
{
    public partial class Start : Form
    {
       
        public Start()
        {
            InitializeComponent();
        }
        //ein Objekt von UserController erzeugt
        
        UserController uc = new UserController();

        /*Event Button Search:
         * SearchModus, man kann nur Worter suchen, hoeren und schauen
         */
        #region
        private void btnSearch_Click(object sender, EventArgs e)
        {         
            uc.SearchModus();
            this.Hide();//Haupt Fenster wird geschwunden, kommt nur neues Fenster danach
        }
        #endregion
       
        /*Event Button Management:
         * ManagementModus, man kann hier mit Daten bearbeiten
         */
        #region
        private void btnManagement_Click(object sender, EventArgs e)
        {
            //Wenn man Adminitritor sei, kann man hier Add, Delete, Alter Datei
            //der muss einloggen, um Data zuzugreifen
            LoginGrpBox.Show();
        }
        #endregion
         /* Event loggin Button:
         * zuhoerigen ManagementModus, bestaetigen , ob der Nutzer Recht hat.
         * wenn User einlogt, wuerde es mit Database vergleichen
         * wenn user und passwort gleich sind -> Management Form
         * sonst ein Warnungnachricht anzeigen
          */
        #region
        private void btn_Login_Click(object sender, EventArgs e)
        {

            string user = txb_usr.Text;
            string pass = txb_pass.Text;
            bool result = uc.ManagementModus(user, pass); // test User
            if (result == true)
            {
                //uc.ShowManagement();
                ManagementData md = new ManagementData();
                md.Show();
                this.Hide(); // aktuelle Fenster zu
            }
            else
            {
                MessageBox.Show("User und Password nicht korrect! ");
            }
            txb_usr.Text = txb_pass.Text = ""; // setzen alle TextBox als leer

           

            #endregion
           
        }
        //Event Button Exit Login
        #region
        private void btn_Exit_Click(object sender, EventArgs e)
        {

            //this.Close();
            Application.Exit();


        }
        #endregion
        //Wenn User Kreuze Knoten oben rechts des Formes , werden ein Confirm Message anzeigen 
        //#region
        private void Start_FormClosing(object sender, FormClosingEventArgs e)
        {
        //    DialogResult dialog = MessageBox.Show("Do you want to close it?", "", MessageBoxButtons.YesNo);
        //    if (dialog != DialogResult.Yes)
        //    {
        //        e.Cancel = true;
        //    }
        //    else
        //    {
        //        if (Application.OpenForms.Count >= 0)
                    Application.Exit();
        //        //this.Close();

        //    }


        }
        //#endregion

    }
}
