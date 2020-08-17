using PersonalDictionary.DataController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalDictionary.Model
{
    public class LoginModel : IMainModel
    {
        private string _username;
        private string _password;
        public string UsernameText
        {
            get { return _username; }
            set { _username = value; }
        }
        public string PasswordText 
        {
            get { return _password; }
            set { _password = value; }
        }

        public LoginModel(string username, string pass) 
        {
            this._username = username;
            this._password = pass;
        }
        public LoginModel() { }

        public void Search()
        {
            MainForm main = new MainForm();
            main.Show();
        }

        public void ShowManagement()
        {
            ManagementData md = new ManagementData();
            md.Show();
        }
    }
}
