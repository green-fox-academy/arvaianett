using System;
using System.IO;

namespace _06_CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"D:\Homework\my-file.txt";
            string path2 = @"D:\Homework\file2";

            Console.WriteLine(Copy(path1, path2));

            Console.ReadLine();
        }

        static bool Copy(string path1, string path2)
        {
            try
            {
                string[] copyFrom = File.ReadAllLines(path1);

                File.WriteAllLines(path2, copyFrom);

                string[] copyTo = File.ReadAllLines(path2);
                
                if (copyFrom.Length == copyTo.Length)
                {                    
                    Console.WriteLine("The copy was succesful");
                }

                return true;
            }
            catch (Exception)
            {
                Console.WriteLine(0);

                return false;
            }            
        }
    }
}
