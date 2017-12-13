using NUnit.Framework;
using appples;

namespace Test
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            AppleTest apple = new AppleTest();

            var result = apple.GetApple("apple");

            Assert.AreEqual("apple", result);
        }
    }
}
