using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDictionary.DataController
{
    // Abstract class : Definition der UserController Klasse
    public abstract class Control
    {
        //void Login(string username, string pass);
       public abstract void Search();
       public abstract void ShowManagement();
    }
        
} 
