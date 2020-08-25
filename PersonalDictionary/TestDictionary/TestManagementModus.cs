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
        DictionarySearchModel dsm;
        [SetUp]
        public void Setup()
        {
            dmm = new DicManagementModel();

        }
        [Test]
        public void AddNewDataToDatabaseSuccess()
        {
             dmm.AddData(SQLdata.sql, "add_dict", 24, "schönen", "xinh", "xinh đẹp");
            DataTable dt = dmm.Search("Lookup_dict", "schön", "VNShort");
            Assert.AreEqual(1, dt.Rows.Count);           

        }
        [Test]
        public void EditDataFromTextBoxAndUpToDatabase()
        {

            dmm.EditData(SQLdata.sql, "Edit_dict", 23, "schön", "xinh", "xinh đẹp");
            //DataTable dt = dsm.Search("Lookup_back", "xinh xinh", "German");
            DataTable dt = dsm.Search(SQLdata.sql, "Lookup_dict", "schön");
            //Assert.AreEqual(1, dt.Rows.Count);
            //DataTable dt = dsm.Search("Lookup_back", "Xin chào", "German");
            Assert.IsTrue(dt.Rows.Count > 0);
        }
        [Test]
        public void DeleteDataFromDatabase()
        {

            dmm.DeleteData(TableProcedure.Delete_dict.ToString(), 1);
            DataTable dt = dsm.Search(SQLdata.sql, "Lookup_dict", "Gesundheit");
            Assert.IsNull(dt);
        }
    
    }
}
