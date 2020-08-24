using NUnit.Framework;
using PersonalDictionary;

namespace Cal.Test
{
    [TestFixture]
    public class Tests
    {
        private Calculator _cal;
        [SetUp]
        public void Setup()
        {
            _cal = new PersonalDictionary.Calculator();
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(7, _cal.Add(3, 4));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(12, _cal.Mul(3, 4));
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual(14, _cal.Mul(7, 2));
        }
        [Test]
        public void Test4()
        {
            Assert.AreEqual(14, _cal.Mul(7, 2));
        }
    }
}