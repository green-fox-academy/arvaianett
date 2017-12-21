using System;
using System.Collections.Generic;
using System.IO;

namespace FavouriteAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            Save animals = new Save();

            if (args.Length == 0)
            {
                string path = @"D:\greenfox\arvaianett\week-05\FavouriteAnimals\animals.txt";

                string readAnimals = File.ReadAllText(path);

                Console.WriteLine(readAnimals);
            }

            else if (args.Length != 0)
            {
                animals.SaveToTextFile(args);
            }
        }
    }
}
