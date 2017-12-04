using System;
using System.IO;

namespace _05_WriteMultipleLines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Path: ");
            string path = Console.ReadLine();

            Console.WriteLine("Word: ");
            string word = Console.ReadLine();

            Console.WriteLine("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Function(path, word, number));

            Console.ReadLine();
        }

        static string[] Function(string path, string word, int number)
        {
            string[] array = new string[number];

            try
            {
                for (int i = 0; i < number; i++)
                {
                    array[i] = word;
                }

                File.WriteAllLines(path, array);
            }
            catch (Exception)
            {
                Console.WriteLine(0);
            }
            return array;
        }
    }
}
