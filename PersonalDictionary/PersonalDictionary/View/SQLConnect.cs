using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDictionary.DataController
{
    public abstract class SQLConnect
    {
        public static string sql = @"server=DESKTOP-2RGH5S5;database=DictionaryData;integrated security =true";
        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(sql))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connect.Close();
            } ;
            return data;
        }
        

        public string A { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string UsernameText { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PasswordText { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
