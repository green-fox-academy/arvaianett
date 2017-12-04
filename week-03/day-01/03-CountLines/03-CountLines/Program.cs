using System;
using System.IO;

namespace _03_CountLines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Filename: ");

            string input = Console.ReadLine();

            FileName(input);

            Console.ReadLine();
        }

        static int FileName(string name)
        {
            int number = 0;

            try
            {
                string[] array = File.ReadAllLines(name);

                number = array.Length;

                Console.WriteLine(number);
            }
            catch (Exception)
            {
                Console.WriteLine(0);
            }
            return number;
        }
    }
}
