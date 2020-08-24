using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalDictionary.Model
{
    //Definition fuer Funktionen- oder AktivitaetenGruppe
    //Gernerationklasse von LoginModels , die erhaeltet nötigen Mothoden von LoginModels
    public  interface ILogin
    {
        //void ShowManagementModus();
        //bool checkLogin(string user, string pass);
      
        void SearchModus();
        bool checkLogin(string user, string pass);
    }
}
