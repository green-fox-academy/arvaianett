using NUnit.Framework;
using Animal;

namespace AnimalTest
{
    [TestFixture]
    public class UnitTest1
    {
        AnimalClass animal = new AnimalClass();

        [Test]
        public void TestMethod1()
        {
            var resultEat = animal.Eat(3);

            Assert.AreEqual(47, resultEat);
        }

        [Test]
        public void TestMethod2()
        {
            var resultDrink = animal.Drink(4);

            Assert.AreEqual(46, resultDrink);
        }

        [Test]
        public void TestMethod3()
        {
            var resultPlayHunger = animal.PlayHunger(7);

            Assert.AreEqual(54, resultPlayHunger);
        }

        [Test]
        public void TestMethod4()
        {
            var resultPlayThirst = animal.PlayThirst(9);

            Assert.AreEqual(55, resultPlayThirst);
        }
    }
}
