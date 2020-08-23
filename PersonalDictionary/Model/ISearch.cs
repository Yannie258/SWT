using SpeechLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDictionary.Model
{
    public interface ISearch
    {
        void s_back();
        DataTable load();
        


        bool SearchGerman(string german, string mean, string detail);
        bool SearchMean(string german, string means, string details);
    }
}
