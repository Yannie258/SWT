
using PersonalDictionary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDictionary.Controller
{
    class UserController 
    {
        //ein Objekt von LoginData erzeugen
        LoginModels log = new LoginModels();

        //Erfassen  die Anforderung des Benutzers und bezieht es sich auf das LoginModels, um dem Benutzer die Daten zurueckzugeben
        public void SearchModus()
        {
            log.SearchModus();
        }
        //public void ShowManagement()
        //{
        //    log.ShowManagementModus();

        //}
        public bool ManagementModus(string user, string pass)
        {
            
            return log.checkLogin(user,pass);
        }
    }
}
