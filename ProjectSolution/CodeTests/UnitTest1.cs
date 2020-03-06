using NUnit.Framework;
using ProjectGui;
using System.Linq;

namespace CodeTests
{
    public class Tests
    {
        private CodeLayer _code;
        [SetUp]
        public void Setup()
        {
             _code = new CodeLayer();
        }

        [Test]
        public void CountListofCpus()
        {
            var expected = 6;
            var result = _code.GetList().Count;
            Assert.AreEqual(expected, result);
           
        }

        [Test]
        public void CountListUsers() 
        {
            var expected = 1;
            var result = _code.GetList().Count();
            Assert.AreEqual(expected, result);
        }



    }
}