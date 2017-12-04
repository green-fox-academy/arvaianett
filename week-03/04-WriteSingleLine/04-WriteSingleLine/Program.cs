using System;
using System.IO;

namespace _04_WriteSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"D:\Homework\my-file.txt");

            string line = "";

            while (line != null)
            {
                line = sr.ReadLine();
                Console.WriteLine(line);
            }

            sr.Close();

            try
            {
                StreamWriter sw = new StreamWriter(@"D:\Homework\my-file.txt", true);

                string input = "Anett";

                sw.WriteLine(input);

                sw.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to write file: my-file.txt");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
