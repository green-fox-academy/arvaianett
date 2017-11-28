using System;

namespace d1_exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            string kilometer = Console.ReadLine();

            Console.WriteLine("Distance in kilometers: " + kilometer + " km");

            double miles = double.Parse(kilometer) * 0.621371;

            Console.WriteLine("Distance: " + miles + " mi");

            Console.ReadLine();
        }
    }
}
