using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GardenApp
{
    public class Garden
    {
        public List<Plants> listOfPlants;

        public Garden()
        {
            listOfPlants = new List<Plants>();
        }

        public void WaterAllPlants(double wateringAmount)
        {
            Console.WriteLine($"Watering with {wateringAmount}");

            double counter = 0;

            for (int i = 0; i < listOfPlants.Count; i++)
            {
                if (listOfPlants[i] is Flowers && listOfPlants[i].WhenItNeedsMore < listOfPlants[i].currentWaterAmount)
                {
                    counter++;
                }
                else if (listOfPlants[i] is Trees && listOfPlants[i].WhenItNeedsMore < listOfPlants[i].currentWaterAmount)
                {
                    counter++;
                }
            }

            Watering(wateringAmount, counter);
        }

        public void Watering(double wateringAmount, double counter)
        {
            for (int i = 0; i < listOfPlants.Count; i++)
            {
                if (listOfPlants[i] is Flowers && listOfPlants[i].WhenItNeedsMore < listOfPlants[i].currentWaterAmount)
                {
                    listOfPlants[i].currentWaterAmount = listOfPlants[i].currentWaterAmount + ((wateringAmount / counter) * listOfPlants[i].WaterAbsorb);
                }
                else if (listOfPlants[i] is Trees)
                {
                    listOfPlants[i].currentWaterAmount = listOfPlants[i].currentWaterAmount + ((wateringAmount / counter) * listOfPlants[i].WaterAbsorb);
                }
            }
        }

        public void HowItLooksLike()
        {
            for (int i = 0; i < listOfPlants.Count; i++)
            {
                if (listOfPlants[i] is Flowers && listOfPlants[i].currentWaterAmount < listOfPlants[i].WhenItNeedsMore)
                {
                    Console.WriteLine("The {0} {1} needs water.", listOfPlants[i].color, listOfPlants[i].Type);
                }
                else if (listOfPlants[i] is Flowers && listOfPlants[i].currentWaterAmount > listOfPlants[i].WhenItNeedsMore)
                {
                    Console.WriteLine("The {0} {1} doesnt need water.", listOfPlants[i].color, listOfPlants[i].Type);
                }
                else if (listOfPlants[i] is Trees && listOfPlants[i].currentWaterAmount < listOfPlants[i].WhenItNeedsMore)
                {
                    Console.WriteLine("The {0} {1} needs water.", listOfPlants[i].color, listOfPlants[i].Type);
                }
                else
                {
                    Console.WriteLine("The {0} {1} doesnt need water.", listOfPlants[i].color, listOfPlants[i].Type);
                }
            }
        }
    }
}
