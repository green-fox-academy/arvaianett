using NUnit.Framework;
using Sharpie;

namespace SharpieTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            SharpieClass sharpie = new SharpieClass();

            var result = sharpie.Use(5.0f);

            Assert.AreEqual(95, result);
        }
    }
}
