using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDictionary.Model
{
    public interface IManagement
    {
        void back();
        bool Add(int Id, string German, string VNShort, string VNLong);
        
    }
}
