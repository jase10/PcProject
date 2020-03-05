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
        public void Test1()
        {
            var expected = 6;
            var result = _code.GetList().Count;
            Assert.AreEqual(expected, result);
           
        }


    }
}