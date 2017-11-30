using System;

namespace d2_17._Swap_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] abc = { "first", "second", "third" };

            string temp1 = abc[0];
            string temp2 = abc[2];

            abc[0] = temp2;
            abc[2] = temp1;

            foreach (string ab in abc)
            {
                Console.WriteLine(ab);
            }
            Console.ReadLine();
        }
    }
}
