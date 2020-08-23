using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalDictionary.Model
{
    //Manage fuer Seach Form
    class DictionarySearchModel : ISearch
    {
        public string German { get; set; }
        public string Mean { get; set; }
        public string Details { get; set; }

        public enum Language
        {
            German,
            VietNam
        }
        
        public DictionarySearchModel() { }
        public DictionarySearchModel( string german,string mean,string detail)
        {
            this.German = german;
            this.Mean = mean;
            this.Details = detail;
        }

        public void s_back()
        {
            Start start = new Start();
            start.Show();
        }

        public DataTable load()
        {
            DataTable re;
           
            re= SqlHelper.SqlHelper.ExecuteDataset(SQLdata.sql, "select_dict").Tables[0];

            return re;
        }
        public bool SearchGerman(string german, string mean, string detail)
        {
            bool result = false;
            // gefundene Wort wurde in einem temperatoren Table und in Textbox anzeigen
            DataTable dt = SqlHelper.SqlHelper.ExecuteDataset(SQLdata.sql, "Lookup_dict", german).Tables[0];
            int count = dt.Rows.Count;
            if (count > 0)
            {
                mean = dt.Rows[0]["VNShort"].ToString();
                detail = dt.Rows[0]["VNLong"].ToString();
                result = true;
                return result;
            }
            return result;
        }
        public bool SearchMean(string german, string mean, string details)
        {
            return true;
        }
    }
}
