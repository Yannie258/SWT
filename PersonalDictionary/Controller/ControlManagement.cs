using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDictionary.Controller
{
    public abstract class ControlManagement
    {
        public abstract bool Back();
        public abstract bool Add(int Id, string German, string VNShort, string VNLong);
    }
}
