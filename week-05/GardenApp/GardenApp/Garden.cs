using System;
using System.Collections.Generic;
using System.Text;

namespace GardenApp
{
    public class Garden
    {
        public List<Plants> listOfPlants;
        public List<Plants> wateringList;
        private double flowerWaterAbsorb = 0.75;
        private double treeWaterAbsorb = 0.4;
        private const double waterAmountWhenFlowerNeedsMore = 5;
        private const double waterAmountWhenTreeNeedsMore = 10;

        public Garden()
        {
            listOfPlants = new List<Plants>();
            wateringList = new List<Plants>();
        }

        public void HowItLooksLike()
        {
            for (int i = 0; i < listOfPlants.Count; i++)
            {
                if (listOfPlants[i] is Flowers && listOfPlants[i].currentWaterAmount < waterAmountWhenFlowerNeedsMore)
                {
                    Console.WriteLine($"The {listOfPlants[i].color} Flower needs water.");
                }
                else if (listOfPlants[i] is Flowers && listOfPlants[i].currentWaterAmount > waterAmountWhenFlowerNeedsMore)
                {
                    Console.WriteLine($"The {listOfPlants[i].color} Flower doesnt need water.");
                }
                else if (listOfPlants[i] is Trees && listOfPlants[i].currentWaterAmount < waterAmountWhenTreeNeedsMore)
                {
                    Console.WriteLine($"The {listOfPlants[i].color} Trees needs water.");
                }
                else if (listOfPlants[i] is Trees && listOfPlants[i].currentWaterAmount > waterAmountWhenTreeNeedsMore)
                {
                    Console.WriteLine($"The {listOfPlants[i].color} Trees doesnt need water.");
                }
            }
        }
        public void WaterAllPlants(double wateringAmount)
        {
            Console.WriteLine($"Watering with {wateringAmount}");

            for (int i = 0; i < listOfPlants.Count; i++)
            {
                if (listOfPlants[i] is Flowers && waterAmountWhenFlowerNeedsMore < listOfPlants[i].currentWaterAmount)
                {
                    Watering(wateringAmount);
                }
                else if (listOfPlants[i] is Trees && waterAmountWhenTreeNeedsMore < listOfPlants[i].currentWaterAmount)
                {
                    Watering(wateringAmount);
                }

                wateringList.Add(listOfPlants[i]);
            }
        }

        public void Watering(double wateringAmount)
        {
            for (int i = 0; i < wateringList.Count; i++)
            {
                if (wateringList[i] is Flowers)
                {
                    wateringList[i].currentWaterAmount = listOfPlants[i].currentWaterAmount + ((wateringAmount / wateringList.Count) * flowerWaterAbsorb);
                }
                else if (wateringList[i] is Trees)
                {
                    wateringList[i].currentWaterAmount = listOfPlants[i].currentWaterAmount + ((wateringAmount / wateringList.Count) * treeWaterAbsorb);
                }
            }
        }
    }
}
