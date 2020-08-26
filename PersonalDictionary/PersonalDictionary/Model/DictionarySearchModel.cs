using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalDictionary.Model
{
    //Manage fuer Seach Modus
    public class DictionarySearchModel : DictionaryDataManagementBase
    {
        

        public DictionarySearchModel() { }
        public DictionarySearchModel(string german, string mean, string detail)
        {
            this.German = german;
            this.Mean = mean;
            this.Detail = detail;
        }

        //Enum fuer Procedure
        public enum TableProcedure
        {
            select_dict,
            Lookup_dict
        };

        #region       Load Data from Database to ListBox
        /*
         * load Data from Database in Store Procedure "select_dict"
        * */

        public override DataTable Load_data()
        {
            DataTable re;

            string tp = TableProcedure.select_dict.ToString();
            //alle Daten  in Temperate DataTable re abgespeichert.
            // public static DataSet ExecuteDataset(string connectionString, string spName, params object[] parameterValues);
            re = SqlHelper.SqlHelper.ExecuteDataset(SQLdata.sql, tp).Tables[0];
            return re;
        }
        #endregion

        #region  Load Data from ListBox to TextBox, when user a Row in List click
        /*
         * load Data from Database in Store Procedure "Lookup_dict"
         * */

        public override DataTable Load_to_TextBox(string gm)
        {
            DataTable re;
            string tp = TableProcedure.Lookup_dict.ToString();
            //alle Daten  in Temperate DataTable re abgespeichert.
            re = SqlHelper.SqlHelper.ExecuteDataset(SQLdata.sql, tp, gm).Tables[0];
            return re;
        }


        #endregion

        #region Filter Data 
        /*Suchen  Wortsbedeutung und Wortserklärung nach Procedure
         * */

        public override DataTable Search(string sql, string table,string word)
        {
            DataTable dt = SqlHelper.SqlHelper.ExecuteDataset(SQLdata.sql, table, word).Tables[0];
            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            dt = null;

            return dt;
        }
        #endregion

    }
}
