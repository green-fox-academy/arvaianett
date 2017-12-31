using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\greenfox\arvaianett\week-05\Lottery\text.txt";
           
            //StreamReader file = new StreamReader(filePath);
            List<int> numberList = new List<int>();
            string line;
            using (StreamReader file = new StreamReader(filePath))
            {
                while ((line = file.ReadLine()) != null)
                {
                    List<string> numbersFromFile = new List<string>();

                    numbersFromFile = line.Split(';').ToList<string>();

                    numbersFromFile.Reverse();

                    var firstFiveItems = numbersFromFile.Take(5);

                    foreach (var numbersLottery in firstFiveItems)
                    {
                        numberList.Add(int.Parse(numbersLottery));
                    }
                }
            }

            NumberFrequency(numberList);

            Console.ReadLine();
        }

        public static List<int> CheckNumbers(List<string> numbersFromFile)
        {
            List<int> lotteryNumbers = new List<int>();

            List<string> numbers = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            for (int i = 0; i < numbersFromFile.Count; i++)
            {
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (numbersFromFile[i].Contains(numbers[j]) && !lotteryNumbers.Contains(int.Parse(numbersFromFile[i])))
                    {
                        lotteryNumbers.Add(int.Parse(numbersFromFile[i]));
                    }
                }
            }

            return lotteryNumbers;
        }

        public static void NumberFrequency(List<int> numbersFromFile)
        {
            Dictionary<int, int> countFrequency = new Dictionary<int, int>();

            foreach (int lotteryNumbers in numbersFromFile)
            {
                if(countFrequency.ContainsKey(lotteryNumbers))
                {
                    int value = countFrequency[lotteryNumbers];
                    value++;
                    countFrequency[lotteryNumbers] = value;
                }
                else
                {
                    countFrequency.Add(lotteryNumbers, 1);
                }
            }

            int first = int.MinValue;
            int second = int.MinValue;
            int third = int.MinValue;
            int fourth = int.MinValue;
            int fifth = int.MinValue;
            int sixth = int.MinValue;

            List<int> fiveLargest = new List<int>();

            foreach (int i in countFrequency.Values)
            {
                if (i > first)
                {
                    second = first;
                    first = i;
                }
                else if (i > second)
                {
                    third = second;
                    second = i;
                }
                else if (i > third)
                {
                    fourth = third;
                    fourth = i;
                }
                else if (i > fifth)
                {
                    sixth = fifth;
                    fifth = i;
                }
            }

            foreach (KeyValuePair<int, int> pair in countFrequency)
            {
                if (pair.Value == first || pair.Value == second || pair.Value == third || pair.Value == fourth || pair.Value == fifth)
                {
                    Console.WriteLine("{0}, {1}", pair.Key, pair.Value);
                }
            }
        }
    }
}
