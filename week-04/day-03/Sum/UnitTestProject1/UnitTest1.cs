using Sum;
using NUnit.Framework;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            SumClass sum1 = new SumClass();

            var list1 = new List<int>() { 1, 2, 3 };

            var result1 = sum1.Sum(list1);

            Assert.AreEqual(6, result1);
        }

        [Test]
        public void TestMethod2()
        {
            SumClass sum2 = new SumClass();

            var list2 = new List<int>() { };

            var result2 = sum2.Sum(list2);

            Assert.AreEqual(0, result2);
        }

        [Test]
        public void TestMethod3()
        {
            SumClass sum3 = new SumClass();

            var list3 = new List<int>() {4 };

            var result3 = sum3.Sum(list3);

            Assert.AreEqual(4, result3);
        }

        [Test]
        public void TestMethod4()
        {
            SumClass sum4 = new SumClass();

            var result = sum4.Sum(null);
            
            Assert.AreEqual(null, result);
        }
    }
}
