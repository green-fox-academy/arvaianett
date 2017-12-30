using System;
using System.Collections.Generic;
using System.IO;

namespace DuplicatedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\greenfox\arvaianett\week-05\DuplicatedChars\text.txt";

            ReadAndModifyFile(filePath);
        }

        public static void ReadAndModifyFile(string filePath)
        {
            StreamReader file = new StreamReader(filePath);

            string line;

            while ((line = file.ReadLine()) != null)
            {
                char[] lineChar = line.ToCharArray();

                List<char> lineList = new List<char>() { };

                for (int i = 0; i < line.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        lineList.Add(lineChar[i]);
                    }
                }

                string finalLine = string.Join("", lineList);

                Console.WriteLine(finalLine);
            }
            
            Console.ReadLine();
        }
    }
}
