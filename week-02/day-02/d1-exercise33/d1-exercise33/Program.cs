using System;

namespace d1_exercise33
{
    class Program
    {
        static void Main(string[] args)
        {
            bool num = true;

            do
            {
                Console.WriteLine("Have a guess: ");
                string number = Console.ReadLine();

                if (int.Parse(number) > 8)
                {
                    Console.WriteLine("The stored number is higher");
                }
                else if (int.Parse(number) < 8)
                {
                    Console.WriteLine("The stored number is lower");
                }
                else if (int.Parse(number) == 8)
                {
                    Console.WriteLine("You found the number: 8");
                    num = false;
                }
            } while (num);

            Console.ReadLine();
        }
    }
}
