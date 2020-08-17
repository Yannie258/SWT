using PersonalDictionary.DataController;
using PersonalDictionary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDictionary.Controller
{
    class UserController:Control
    {
        //ein Objekt von LoginData erzeugen
        LoginModel log = new LoginModel();


        /* Implementieren abstract Methode von Control Klasse
         * abstrakten Methode überschreiben. 
         */
        public override void Search()
        {
            log.Search();
        }
       

        public override void ShowManagement()
        {
            log.ShowManagement();
        }
    }
}
