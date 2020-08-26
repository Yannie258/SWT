using PersonalDictionary.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDictionary.Controller
{
    public class ControlManagement
    {
        DicManagementModel dmm = new DicManagementModel();
        //load data
        public DataTable LoadDataTable()
        {
            return dmm.Load_data();
        }
        public DataTable LoadDataToTextBox(string german)
        {
            return dmm.Load_to_TextBox(german);
        }
       
        public DataTable Search(string sql, string sp, string word)
        {
            return dmm.Search(sql, sp, word);
        }
        //public void AddToDB(int ID, string German, string Mean, string Detail)
        //{
        //    dmm.AddData(ID, German, Mean, Detail);

        //}
        public void AddToDB(string sql, string table,int ID, string German, string Mean, string Detail)
        {
             dmm.AddData(sql,table,ID, German, Mean, Detail);

        }
        //public void DeteleData(string table,int id)
        //{
        //    dmm.AddData(ID, German, Mean, Detail);

        //}
        public void DeleteData(string table, int id)
        {
            dmm.DeleteData(table, id);

        }
        public void EditData(string sql, string table, int ID, string German, string Mean, string Detail)
        {
            dmm.EditData(sql, table, ID, German, Mean, Detail);
        }
    }
}
