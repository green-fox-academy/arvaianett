using System;
using System.Collections.Generic;

namespace GardenApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Plants flower1 = new Flowers("yellow", 6);
            Plants flower2 = new Flowers("blue", 4);
            Plants tree1 = new Trees("purple", 6);
            Plants tree2 = new Trees("orange", 9);

            List<Plants> listOfPlants = new List<Plants>();

            var garden = new Garden();

            garden.listOfPlants.Add(flower1);
            garden.listOfPlants.Add(flower2);
            garden.listOfPlants.Add(tree1);
            garden.listOfPlants.Add(tree2);

            garden.HowItLooksLike();

            garden.WaterAllPlants(40);

            garden.HowItLooksLike();

            garden.WaterAllPlants(70);

            garden.HowItLooksLike();

            Console.ReadLine();
        }
    }
}
