using System;

namespace d2_12._Print_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] af = { 4, 5, 6, 7 };
            
            foreach (int number in af)
            {
                Console.WriteLine(number);
            }
            
            Console.ReadLine();
        }
    }
}
