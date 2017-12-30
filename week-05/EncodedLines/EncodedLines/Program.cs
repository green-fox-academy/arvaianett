using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EncodedLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\greenfox\arvaianett\week-05\EncodedLines\text.txt";

            Dictionary<char, int> abc = new Dictionary<char, int>
            {
                { 'a', 1 },
                { 'b', 2 },
                { 'c', 3 },
                { 'd', 4 },
                { 'e', 5 },
                { 'f', 6 },
                { 'g', 7 },
                { 'h', 8 },
                { 'i', 9 },
                { 'j', 10 },
                { 'k', 11 },
                { 'l', 12 },
                { 'm', 13 },
                { 'n', 14 },
                { 'o', 15 },
                { 'p', 16 },
                { 'q', 17 },
                { 'r', 18 },
                { 's', 19 },
                { 't', 20 },
                { 'u', 21 },
                { 'v', 22 },
                { 'w', 23 },
                { 'x', 24 },
                { 'y', 25 },
                { 'z', 26 },
                { '.', 27 },
                { '/', 28 },
                { '*', 29 },
                { '+', 30 },
                { '\'', 31 },
                { '(', 32 },
                { '!', 33 },
                { '"', 34 },
                { 'A', 35 },
                { 'B', 36 },
                { 'C', 37 },
                { 'D', 38 },
                { 'E', 39 },
                { 'F', 40 },
                { 'G', 41 },
                { 'H', 42 },
                { 'I', 43 },
                { 'J', 44 },
                { 'K', 45 },
                { 'L', 46 },
                { 'M', 47 },
                { 'N', 48 },
                { 'O', 49 },
                { 'P', 50 },
                { 'Q', 51 },
                { 'R', 52 },
                { 'S', 53 },
                { 'T', 54 },
                { 'U', 55 },
                { 'V', 56 },
                { 'W', 57 },
                { 'X', 58 },
                { 'Y', 59 },
                { 'Z', 60 },
                { '[', 61 },
                { ' ', 62 },
                { '-', 63 },
                { ',', 64 }
            };

            List<char> listNumber = abc.Keys.ToList();

            StreamReader file = new StreamReader(filePath);

            string line;

            while ((line = file.ReadLine()) != null)
            {
                char[] linesArray = line.ToCharArray();

                List<char> charList = new List<char>();

                for (int i = 0; i < linesArray.Length; i++)
                {
                    int value = abc[linesArray[i]];

                    if (value == 1)
                    {
                        charList.Add('b');
                    }
                    else if (value == 27)
                    {
                        charList.Add('-');
                    }
                    else if (value == 62)
                    {
                        charList.Add(' ');
                    }
                    else
                    {
                        char letter = listNumber[value - 2];
                        charList.Add(letter);
                    }
                }

                string finalLine = string.Join("", charList);

                Console.WriteLine(finalLine);
            }

            Console.ReadLine();
        }
    }
}
