using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDictionary.Model
{
    public interface IDataAccess
    {
       void AddData(string sql,string table,int ID, string German, string Mean, string Detail);
       void DeleteData(string table, int id);
       void EditData(string sql, string table, int ID, string German, string Mean, string Detail);
    }
}
