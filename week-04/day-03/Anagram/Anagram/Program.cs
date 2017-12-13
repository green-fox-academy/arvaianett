using System;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class AnagramClass
    {
        public string word1 = "";
        public string word2 = "";

        public bool AnagramMethod(string word1, string word2)
        {
            int sum = 0;

            for (int i = 0; i < word2.Length; i++)
            {
                for (int j = 0; j < word1.Length; j++)
                {
                    if (word1[i].Equals(word2[j]))
                    {
                        sum += 0;
                    }
                    else
                    {
                        sum += 1;
                    }
                }
            }

            if(sum == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
