using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PersonalDictionary;
using PersonalDictionary.Model;

namespace TestDictionary
{
    [TestFixture]
    public class TestManagementModus
    {
        DicManagementModel dmm;
       
        [SetUp]
        public void Setup()
        {
            dmm = new DicManagementModel();

        }
        [Test]
        public void AddNewDataToDatabaseSuccess()
        {
             dmm.AddData(SQLdata.sql, "add_dict", 26, "kalter", "lanh", "xinh đẹp");
            DataTable dt = dmm.Search(SQLdata.sql,"Lookup_dict", "schön");
            Assert.AreEqual(1, dt.Rows.Count);           

        }
       
        [Test]
        public void EditDataFromTextBoxAndUpToDatabase()
        {

            dmm.EditData(SQLdata.sql, "Edit_dict", 26, "kalter", "xinh", "xinh đẹp");
            DataTable dt = dmm.Search(SQLdata.sql, "Lookup_dict", "kalter");
            Assert.AreEqual(1, dt.Rows.Count);
 
        }
        [Test]
        public void DeleteDataFromDatabase()
        {

            dmm.DeleteData(TableProcedure.Delete_dict.ToString(), 26);
            DataTable dt = dmm.Search(SQLdata.sql, "Lookup_dict", "kalter");
            Assert.IsNull(dt);
        }
    
    }
}
