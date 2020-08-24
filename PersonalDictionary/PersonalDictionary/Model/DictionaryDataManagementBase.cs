using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDictionary.Model
{
    public abstract class DictionaryDataManagementBase
    {
       
        //private string _german;
        //private string _mean;
        //private string _detail;
       
        public string German { get; set; }
        public string Mean { get; set; }
        public string Detail { get; set; }

        public DictionaryDataManagementBase()
        {

        }
        public DictionaryDataManagementBase(string german,string mean,string detail)
        {
            this.German = german;
            this.Mean = mean;
            this.Detail = detail;
        }
       

        public abstract DataTable Load_data();
        public abstract DataTable Load_to_TextBox(string german);


        public abstract DataTable Search(string table, string SearchLetter, string columnFound);
        

       

        
       
    }
}
