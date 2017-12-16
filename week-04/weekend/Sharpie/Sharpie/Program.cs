using System;

namespace Sharpie
{
    class Program
    {
        static void Main(string[] args)
        {
            SharpieClass sharpie1 = new SharpieClass();

            sharpie1.color = "blue";

            sharpie1.width = 20;

            sharpie1.Use(5.0f);

            Console.WriteLine(sharpie1.InkAmount);

            Console.ReadLine();
        }
    }
}
