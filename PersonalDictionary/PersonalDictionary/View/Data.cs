using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDictionary.DataController
{
    
    //Diese Klasse definiert Tabelle in Datenbanken, ihre Column sowie damit wir Data fuer Query setzen 
    //Das ist DTO (Data Transfer Object) in 3 Schichten-Modell
    public class Data
    {
        //DTO in Datenbank von LoginTable bestehlt aus username und password 
        private string _username;
        private string _password;

        public string username 
        {
            get { return _username; } set { _username = value; } 
        }

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        //Constructor

        public Data()
        {

        }

        public Data(string user, string pass)
        {
            this._username = user;
            this._password = pass;
        }
    }
}
