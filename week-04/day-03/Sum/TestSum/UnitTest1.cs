using NUnit.Framework;
using Sum;
using System.Collections.Generic;

namespace TestSum
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            SumClass sum1 = new SumClass();

            var list1 = new List<int>() {1, 2, 3 };

            var result = list1;

            Assert.AreEqual(6, result);
        }
    }
}
