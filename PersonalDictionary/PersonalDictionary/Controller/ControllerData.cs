using PersonalDictionary.DataController;
using PersonalDictionary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDictionary.Controller
{
    public class ControllerData : ControlManagement
    {
       
        DicManagementModel dm = new DicManagementModel();

        public override bool Add(int Id, string German, string VNShort, string VNLong)
        {
           
           
            return dm.Add(Id,German,VNShort,VNLong);
        }

        //Constructor

        public override bool Back()
        {
            dm.back();
            return true;
        }

       

    }
}
