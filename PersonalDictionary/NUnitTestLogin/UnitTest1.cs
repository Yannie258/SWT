using NUnit.Framework;
using PersonalDictionary.Model;


namespace NUnitTestLogin
{
    [TestFixture]
    public class LoginTests
    {
        private LoginModel login;
        [SetUp]
        public void Setup()
        {
            login = new LoginModel();
        }
       [Test]
        public void checkLoginRight()
        {

            Assert.IsTrue(login.check("admin","admin"));

        }

        [Test]
        public void checkLoginNoRight()
        {
            Assert.IsFalse(login.check("admin2", "admin"));
        }
    }
}