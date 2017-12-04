using System;
using System.IO;

namespace _02_PrintEachLine
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader sr = new StreamReader(@"D:/Homework/my-file.txt");

                string line = "";

                while (line != null)
                {
                    line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to read file: my-file.txt");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
