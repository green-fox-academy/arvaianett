using GardenApp;
using NUnit.Framework;

namespace GardenTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestFlowerWhenItNeedsWater()
        {
            Flowers flower1 = new Flowers("blue", 3);

            flower1.HowItLooksLike();

            Assert.AreEqual("The blue Flower needs water.", "The blue Flower needs water.");
        }

        [Test]
        public void TestFlowerWhenItDoesntNeedWater()
        {
            Flowers flower2 = new Flowers("black", 13);

            flower2.HowItLooksLike();

            Assert.AreEqual("The black Flower doesnt need water.", "The black Flower doesnt need water.");
        }

        [Test]
        public void TestTreeWhenItNeedsWater()
        {
            Trees tree1 = new Trees("white", 1);

            tree1.HowItLooksLike();

            Assert.AreEqual("The white Trees needs water.", "The white Trees needs water.");
        }

        [Test]
        public void TestTreeWhenItDoesntNeedWater()
        {
            Trees tree2 = new Trees("green", 20);

            tree2.HowItLooksLike();

            Assert.AreEqual("The green Trees doesnt need water.", "The green Trees doesnt need water.");
        }

        [Test]
        public void TestFlowerWaterAbsorb()
        {
            Flowers flower3 = new Flowers("red", 2);

            flower3.WaterAllPlants(40);

            flower3.Watering(40);

            Assert.AreEqual(30, 30);
        }

        [Test]
        public void TestFlowerWhenItDoesntNeedWaterWithWatering()
        {
            Flowers flower4 = new Flowers("orange", 12);

            flower4.WaterAllPlants(40);

            flower4.Watering(40);

            Assert.AreEqual(40, 40);
        }

        [Test]
        public void TestTreeWaterAbsorb()
        {
            Trees tree3 = new Trees("green", 2);

            tree3.WaterAllPlants(70);

            tree3.Watering(70);

            Assert.AreEqual(28, 28);
        }

        [Test]
        public void TestTreeWhenItDoesntNeedWaterWithWatering()
        {
            Trees tree4 = new Trees("green", 20);

            tree4.WaterAllPlants(70);

            tree4.Watering(70);

            Assert.AreEqual(20, 20);
        }
    }
}
