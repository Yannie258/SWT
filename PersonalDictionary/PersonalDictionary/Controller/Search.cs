using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDictionary.Controller
{
    public abstract class Search
    {
        public abstract bool s_back();
        public abstract bool SearchGerman(string german, string mean, string detail);
        public abstract DataTable Load();
    }
}
