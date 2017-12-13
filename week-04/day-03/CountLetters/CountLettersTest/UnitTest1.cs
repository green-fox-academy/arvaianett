using NUnit.Framework;
using CountLetters;
using System.Collections.Generic;

namespace CountLettersTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            CountLettersCalss dictionary1 = new CountLettersCalss();

            var result = dictionary1.Count("kac");

            var map1 = new Dictionary<string, int>();

            map1.Add("k", 0);
            map1.Add("a", 1);
            map1.Add("c", 2);

            Assert.AreEqual(map1, result);
        }
    }
}
