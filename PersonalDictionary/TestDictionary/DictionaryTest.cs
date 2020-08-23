using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PersonalDictionary.Model;

namespace TestDictionary
{
    [TestFixture]
    public class DicionaryTest
    {
        private LoginModels login;
        private LoginModels login1;
        [SetUp]
        public void Setup()
        {
            login = new LoginModels();
            
        }

        [Test]
        public void checkUserRightToManagement()
        {
            Assert.IsTrue(login.checkLogin("admin", "admin"));
        }
        [Test]
        public void checkUserNoRightToManagement()
        {
            Assert.IsFalse(login.checkLogin("user", "admin"));
            
        }
        
        


    }
}
