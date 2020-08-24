using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalDictionary.Model
{
    public class DicManagementModel /*:DictionaryDataManagementBase*/
    {
        public int Id { get; set; }
        public string German { get; set; }
        public string VNShort { get; set; }
        public string VNLong { get; set; }

        public DicManagementModel() { }

        public DicManagementModel(int id, string german, string vnShort,string vnLong)
        {
            this.Id = id;
            this.German = german;
            this.VNShort = vnShort;
            this.VNLong = vnLong;
        }
        public void back()
        {
            Start start = new Start();
            start.Show();
        }

        public bool Add(int Id, string German, string VNShort, string VNLong)
        {
            bool re = false;
            try
            {
               int query= SqlHelper.SqlHelper.ExecuteNonQuery(SQLdata.sql, "add_dict", Id, German, VNShort, VNLong);
               if(query > 0)
                {
                    re = true;
                }

            }
            catch { re = false; }
            return re;
        }

        //public override DataTable Load_data()
        //{
        //    throw new NotImplementedException();
        //}

        //public override string getGerman()
        //{
        //    return German;
        //}

        

        //public override DataTable Load_to_TextBox(string german)
        //{
        //    throw new NotImplementedException();
        //}

        //public override string getMean(string mean)
        //{
        //    throw new NotImplementedException();
        //}

        //public override string getDetail(string s)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
