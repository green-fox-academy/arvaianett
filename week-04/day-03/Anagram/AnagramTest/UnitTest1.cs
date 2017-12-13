using NUnit.Framework;
using Anagram;

namespace AnagramTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            AnagramClass anagram1 = new AnagramClass();

            var result = anagram1.AnagramMethod("kacsa", "acksa");

            Assert.True(result = true);
        }
    }
}
