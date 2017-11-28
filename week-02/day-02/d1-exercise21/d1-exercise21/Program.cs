using System;

namespace d1_exercise21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of girls: ");
            string girls = Console.ReadLine();

            Console.WriteLine("Number of boys: ");
            string boys = Console.ReadLine();
            
            if (int.Parse(girls) == int.Parse(boys) && int.Parse(girls) + int.Parse(boys) > 20)
            {
                Console.WriteLine("The party is exellent!");
            }
            else if (int.Parse(girls) == 0)
            {
                Console.WriteLine("Sausage party");
            }
            else if (int.Parse(girls) + int.Parse(boys) > 20 && int.Parse(girls) != int.Parse(boys))
            {
                Console.WriteLine("Quite cool party!");
            }
            else if (int.Parse(girls) + int.Parse(boys) < 20)
            {
                Console.WriteLine("Average party...");
            }
            
            Console.ReadLine();
        }
    }
}
