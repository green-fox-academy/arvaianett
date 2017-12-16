using NUnit.Framework;
using Fibonacci;

namespace FibonacciTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            FibonacciClass fibonacci1 = new FibonacciClass();

            var result = fibonacci1.NthFibonacci(0);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void TestMethod2()
        {
            FibonacciClass fibonacci2 = new FibonacciClass();

            var result = fibonacci2.NthFibonacci(1);

            Assert.AreEqual(1, result);
        }

        [Test]
        public void TestMethod3()
        {
            FibonacciClass fibonacci3 = new FibonacciClass();

            var result = fibonacci3.NthFibonacci(8);

            Assert.AreEqual(21, result);
        }
    }
}
