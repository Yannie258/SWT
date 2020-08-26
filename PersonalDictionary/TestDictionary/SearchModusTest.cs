using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PersonalDictionary;
using PersonalDictionary.Model;
using SqlHelper;

namespace TestDictionary
{
    [TestFixture]
    public class SearchModusTest
    {
        DictionarySearchModel dsm;
       

        [SetUp]
        public void Setup()
        {
            dsm = new DictionarySearchModel();
        }

        [Test]
        public void LoadDataToTableSucccess()
        {
            DataTable test = new DataTable();
            test = SqlHelper.SqlHelper.ExecuteDataset(@"server=DESKTOP-2RGH5S5;database=DictionaryData;integrated security =true", "select_dict").Tables[0];
            //Assert.AreEqual(test.DataSet.Tables.Count, dsm.Load_data().DataSet.Tables.Count);
            //Assert.AreEqual(test.TableName, dsm.Load_data().TableName);
            Assert.IsNotNull(test);
           
        }
       
        [Test]
        public void LoadDataFromListToTextBox()
        {
            DataTable test = new DataTable();
            test= SqlHelper.SqlHelper.ExecuteDataset(@"server=DESKTOP-2RGH5S5;database=DictionaryData;integrated security =true", "Lookup_dict", "Hallo").Tables[0];
            Assert.IsNotNull(test);
        }
        [Test]
        public void SearchGermanToVN()
        {
            //DataTable dt = SqlHelper.SqlHelper.ExecuteDataset(SQLdata.sql, "Lookup_dict", "Danke").Tables[0];
            DataTable dt = dsm.Search(SQLdata.sql,"Lookup_dict","Danke");
            Assert.AreEqual(1, dt.Rows.Count);
        }
        [Test]
        public void NotFoundGermanToVN()
        {
            //DataTable dt = SqlHelper.SqlHelper.ExecuteDataset(SQLdata.sql, "Lookup_dict", "Danke").Tables[0];
            DataTable dt = dsm.Search(SQLdata.sql,"Lookup_dict", "Danken");
            Assert.IsNull(dt);
        }
        [Test]
        public void SearchVNToGerman()
        {
            //DataTable dt = SqlHelper.SqlHelper.ExecuteDataset(SQLdata.sql, "Lookup_dict", "Danke").Tables[0];
            DataTable dt = dsm.Search(SQLdata.sql,"Lookup_back", "Cảm ơn");
            Assert.AreEqual(1, dt.Rows.Count);
        }
        [Test]
        public void NotFoundVNToGerman()
        {
            //DataTable dt = SqlHelper.SqlHelper.ExecuteDataset(SQLdata.sql, "Lookup_dict", "Danke").Tables[0];
            DataTable dt = dsm.Search(SQLdata.sql,"Lookup_back", "kalter");
            Assert.IsNull(dt);
        }

    }
}
