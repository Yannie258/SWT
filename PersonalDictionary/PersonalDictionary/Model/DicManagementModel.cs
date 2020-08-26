using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalDictionary.Model
{
    public class DicManagementModel :DictionaryDataManagementBase,IDataAccess
    {
        public int Id { get; set; }
       
       

        public DicManagementModel() { }

        public DicManagementModel(int id, string german, string vnShort,string vnLong)
        {
            this.Id = id;
            this.German = german;
            this.Mean = vnShort;
            this.Detail = vnLong;
        }

        public override DataTable Load_data()
        {
            DataTable re;

            string tp = TableProcedure.select_dict.ToString();
            //alle Daten  in Temperate DataTable re abgespeichert.
            // public static DataSet ExecuteDataset(string connectionString, string spName (sp:stored procedure), params object[] parameterValues);
            re = SqlHelper.SqlHelper.ExecuteDataset(SQLdata.sql, tp).Tables[0];
            return re;
        }
        //Fuehren Insert Query in SQL aus
       
        public override DataTable Load_to_TextBox(string german)
        {
            throw new NotImplementedException();
        }

        public override DataTable Search(string sql, string table, string searchLetter)
        {
            DataTable dt = SqlHelper.SqlHelper.ExecuteDataset(SQLdata.sql, table, searchLetter).Tables[0];
            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            dt = null;

            return dt;
        }
        //public void AddData(int ID, string German, string Mean, string Detail)
        //{
        //    SqlHelper.SqlHelper.ExecuteNonQuery(SQLdata.sql, TableProcedure.add_dict.ToString(), ID, German, Mean, Detail);

        //}
        public void AddData(string sql,string table,int ID, string German, string Mean, string Detail)
        {
            
            SqlHelper.SqlHelper.ExecuteNonQuery(sql,table,ID, German, Mean, Detail);

            
        }


        public void DeleteData(string table, int id)
        {
            SqlHelper.SqlHelper.ExecuteNonQuery(SQLdata.sql, table,id);
        }

        public void EditData(string sql, string table, int ID, string German, string Mean, string Detail)
        {
            
            SqlHelper.SqlHelper.ExecuteNonQuery(sql,table,ID,German,Mean,Detail);
        }

        
    }
}
