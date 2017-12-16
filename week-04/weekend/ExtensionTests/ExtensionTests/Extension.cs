using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionTests
{
    public class Extension
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int MaxOfThree(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if (b > c && b > a)
            {
                return b;
            }
            else
            {
                return c;
            }
        }

        public double Median(List<double> pool)
        {
            if (pool.Count % 2 == 0)
            {
                return (pool[(pool.Count / 2)] + pool[(pool.Count / 2 - 1)]) / 2;
            }
            else
            {
                return pool[(pool.Count / 2)];
            }
        }

        public bool IsVowel(char c)
        {
            var list = new List<char>() { 'a', 'u', 'o', 'e', 'i' };

            if (list.Contains(c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Translate(string hungarian)
        {
            string teve = hungarian;

            int length = teve.Length;

            for (int i = 0; i < length; i++)
            {
                char c = teve[i];

                if (IsVowel(c))
                {
                    teve = string.Join(c + "v" + c, teve.Split(c));
                    i += 2;
                    length += 2;
                }
            }

            return teve;
        }
    }
}
