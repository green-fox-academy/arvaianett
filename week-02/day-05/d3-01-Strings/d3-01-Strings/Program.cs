using System;

namespace d3_01_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string example = "In a dishwasher far far away";

            string correct = example.Replace("dishwasher", "galaxy");

            Console.WriteLine(correct);

            Console.ReadLine();
        }
    }
}
