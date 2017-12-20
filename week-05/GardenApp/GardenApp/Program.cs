using System;
using System.Collections.Generic;

namespace GardenApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Plants flower1 = new Flowers("yellow", 6);
            Plants flower2 = new Flowers("blue", 2);
            Plants tree1 = new Trees("purple", 14);
            Plants tree2 = new Trees("orange", 1);

            var garden = new Garden();

            garden.listOfPlants.Add(flower1);
            garden.listOfPlants.Add(flower2);            
            garden.listOfPlants.Add(tree1);
            garden.listOfPlants.Add(tree2);

            flower1.HowItLooksLike();
            flower2.HowItLooksLike();
            tree1.HowItLooksLike();
            tree2.HowItLooksLike();

            garden.WaterAllPlants(40);

            flower1.HowItLooksLike();
            flower2.HowItLooksLike();
            tree1.HowItLooksLike();
            tree2.HowItLooksLike();

            garden.WaterAllPlants(70);

            flower1.HowItLooksLike();
            flower2.HowItLooksLike();
            tree1.HowItLooksLike();
            tree2.HowItLooksLike();
        }
    }
}
