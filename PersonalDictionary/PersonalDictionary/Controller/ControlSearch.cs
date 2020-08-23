using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalDictionary.Model;

namespace PersonalDictionary.Controller
{
    public class ControlSearch : Search
    {
        DictionarySearchModel ds = new DictionarySearchModel();

        public override DataTable Load()
        {
            return ds.load();
        }

        public override bool SearchGerman(string german, string mean, string detail)
        {
             
            return ds.SearchGerman(german,mean,detail) ;
        }

        public override bool s_back()
        {
            ds.s_back();
            return true;
        }
    }
}
