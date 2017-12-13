using System;
using System.Collections.Generic;

namespace CountLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class CountLettersCalss
    {
        public Dictionary<string, int> Count(string input)
        {
            var map = new Dictionary<string, int>();

            char[] inputArray = input.ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                map.Add(inputArray[i].ToString(), i);
            }

            return map;
        }
    }
}
