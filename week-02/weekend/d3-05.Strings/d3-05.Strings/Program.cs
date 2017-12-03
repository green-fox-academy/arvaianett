using System;

namespace d3_05.Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            Console.WriteLine(Reverse(reversed));
            Console.ReadLine();
        }

        static string Reverse(string r)
        {
            string reversedstring = string.Empty;           
            
            for (int i = r.Length - 1; i >= 0; i--)
            {
                reversedstring += r[i];
            }
            return reversedstring;
        }
    }
}
