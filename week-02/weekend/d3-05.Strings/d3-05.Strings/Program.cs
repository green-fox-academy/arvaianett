using System;

namespace d3_05.Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a function that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!
            Console.WriteLine(Reverse(reversed));
            Console.ReadLine();
        }

        static string Reverse(string r)
        {
            r.Split();

            Array.Reverse(r);

            return r;
        }
    }
}
