using System;
using System.Collections.Generic;

namespace d5_02.Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var map = new List<Dictionary<string, object>>();

            // Given this list of hashmaps...

            var row0 = new Dictionary<string, object>();
            row0.Add("name", "Rezso");
            row0.Add("age", 9.5);
            row0.Add("candies", 2);
            map.Add(row0);

            var row1 = new Dictionary<string, object>();
            row1.Add("name", "Gerzson");
            row1.Add("age", 10);
            row1.Add("candies", 1);
            map.Add(row1);

            var row2 = new Dictionary<string, object>();
            row2.Add("name", "Aurel");
            row2.Add("age", 7);
            row2.Add("candies", 3);
            map.Add(row2);

            var row3 = new Dictionary<string, object>();
            row3.Add("name", "Zsombor");
            row3.Add("age", 12);
            row3.Add("candies", 5);
            map.Add(row3);

            var row4 = new Dictionary<string, object>();
            row4.Add("name", "Olaf");
            row4.Add("age", 12);
            row4.Add("candies", 7);
            map.Add(row4);

            var row5 = new Dictionary<string, object>();
            row5.Add("name", "Teodor");
            row5.Add("age", 3);
            row5.Add("candies", 2);
            map.Add(row5);

            // Display the following things:
            //  - Who has got more candies than 4 candies
            //  - Sum the age of people who have lass than 5 candies

            int candy0 = Convert.ToInt32(row0["candies"]);
            int candy1 = Convert.ToInt32(row1["candies"]);
            int candy2 = Convert.ToInt32(row2["candies"]);
            int candy3 = Convert.ToInt32(row3["candies"]);
            int candy4 = Convert.ToInt32(row4["candies"]);
            int candy5 = Convert.ToInt32(row5["candies"]);

            if (candy0 > 4)
            {
                Console.WriteLine(row0["name"]);
            }
            if (candy1 > 4)
            {
                Console.WriteLine(row1["name"]);
            }
            if (candy2 > 4)
            {
                Console.WriteLine(row2["name"]);
            }
            if (candy3 > 4)
            {
                Console.WriteLine(row3["name"]);
            }
            if (candy4 > 4)
            {
                Console.WriteLine(row4["name"]);
            }
            if (candy5 > 4)
            {
                Console.WriteLine(row5["name"]);
            }

            int age0 = Convert.ToInt32(row0["age"]);
            int age1 = Convert.ToInt32(row1["age"]);
            int age2 = Convert.ToInt32(row2["age"]);
            int age3 = Convert.ToInt32(row3["age"]);
            int age4 = Convert.ToInt32(row4["age"]);
            int age5 = Convert.ToInt32(row5["age"]);

            Console.ReadLine();
        }
    }
}
