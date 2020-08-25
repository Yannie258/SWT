//using PersonalDictionary.DataController;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalDictionary.Model
{
    //implementieren Interface Ilogin
    public class LoginModels : ILogin
    {
        
        //Kapselung 
        public string Username { get ; set ; }
        public string Password { get ; set ; }

        //Constructor ohne Parameter

        public LoginModels() { }
        //Constructor mit Parameter
        public LoginModels(string username, string pass)
        {
            this.Username= username;
            this.Password = pass;
        }
       
        //Methode zum SearchFenster

        public void SearchModus()
        {
            MainForm main = new MainForm();
            main.Show();
        }

        //Methode zum Managementfenster
        //bevor man zum ManagemmentFenster gehen kann, muss er mit username und passwort einloggen
        //public void ShowManagementModus()
        //{
        //    ManagementData md = new ManagementData();
        //    md.Show();
        //}


        //Methode Username und Password testen
        //es vergleicht mit den erzeugten Daten in Datenbank
        //wenn es ein Ergebnis gibt, gebe es "true" als Rueckwert aus,sonst "false"
        public bool checkLogin(string user, string pass)
        {
            
            bool re = false;
            //rufen Stored Procedure " Login_Select" in Microsoft SQL Server auf
            //SqlHelper.dll ist ein Verweis zum Hiftmethode in SqlClient zuzugreifen. s.Definition alt+F12
            DataTable dt = SqlHelper.SqlHelper.ExecuteDataset(SQLdata.sql, "Login_Select", user, pass).Tables[0];
            try
            {
                if (dt.Rows.Count > 0)
                {

                    re = true;
                    return re;
                }
                return re;
            }
            catch (Exception ex) //fangen Fehler SQL Serverconnect
            {

                MessageBox.Show(ex.Message);
            }
           
            return re;
        }
    }
}
