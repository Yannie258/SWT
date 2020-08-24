using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalDictionary.Model;

namespace PersonalDictionary.Controller
{
    public class ControlSearch 
    {
        DictionarySearchModel dsm = new DictionarySearchModel();

        //Daten in Datenbank werden in ListBox geloadet
        public DataTable LoadDataTable()
        {
            return dsm.Load_data();
        }
        public DataTable LoadDataToTextBox(string german)
        {
            return dsm.Load_to_TextBox(german);
        }
        public DataTable SearchVNFromGerman(string table, string columnSearchName, string columnFound)
        { 
            return dsm.Search(table,columnSearchName,columnFound);
            
        }
        
    }
}
