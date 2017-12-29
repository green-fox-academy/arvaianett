using System;
using System.Collections.Generic;
using System.Text;

namespace TakeMeToThe
{
    public class CandyShop
    {
        private string UnitOfMeasurementSugar { get; set; } = "gr";
        private string Currency { get; set; } = "$";
        private double AllSugar { get; set; }
        private double Income { get; set; }
        private double PriceOfOneGrammSugar { get; set; } = 0.1;
        private double SugarToMakeCandy { get; set; } = 10;
        private double SugarToMakeLollipop { get; set; } = 5;
        List<Lollipop> storedLollipops = new List<Lollipop>();
        List<Candy> storedCandies = new List<Candy>();

        public CandyShop(double amountOfSugar)
        {
            AllSugar = amountOfSugar;
        }

        public void CreateSweets(string typeOfSweet)
        {
            if (typeOfSweet == "candy" && AllSugar > SugarToMakeCandy)
            {
                storedCandies.Add(new Candy());
                AllSugar -= SugarToMakeCandy;
            }
            else if (typeOfSweet == "lollipop" && AllSugar > SugarToMakeLollipop)
            {
                storedLollipops.Add(new Lollipop());
                AllSugar -= SugarToMakeLollipop;
            }
            else if (typeOfSweet != "candy" && typeOfSweet != "lollipop")
            {
                Console.WriteLine("Sorry, we cannot create this type of sweet :(");
            }
            else
            {
                Console.WriteLine("Sorry, we are out of sugar");
            }
        }

        public void Raise(double percentage)
        {
            foreach (Candy candy in storedCandies)
            {
                candy.Price = candy.Price * (1 + percentage / 100);
            }

            foreach (Lollipop lollipop in storedLollipops)
            {
                lollipop.Price = lollipop.Price * (1 + percentage / 100);
            }
        }

        public void Sell(string typeOfSweet, double sellAmount)
        {
            if (typeOfSweet == "lollipop" && storedLollipops.Count != 0 && storedLollipops.Count < sellAmount)
            {
                Console.WriteLine($"Sorry, we have only {0} lollipops on stock", storedLollipops.Count);
            }
            else if (typeOfSweet == "candy" && storedCandies.Count != 0 && storedCandies.Count < sellAmount)
            {
                Console.WriteLine($"Sorry, we have only {0} candies on stock", storedCandies.Count);
            }
            else if (typeOfSweet != "candy" && typeOfSweet != "lollipop")
            {
                Console.WriteLine("Sorry, we do not have this type of sweet");
            }
            else if (typeOfSweet == "candy" && storedCandies.Count == 0)
            {
                Console.WriteLine("Sorry, we are out of candies");
            }
            else if (typeOfSweet == "lollipop" && storedLollipops.Count == 0)
            {
                Console.WriteLine("Sorry, we are out of lollipops");
            }
            else
            {
                for (int i = 0; i < sellAmount; i++)
                {
                    if (typeOfSweet == "candy" && storedCandies.Count != 0)
                    {
                        for (int j = 0; j < 1; j++)
                        {
                            Income += storedCandies[j].Price;
                            storedCandies.Remove(storedCandies[j]);
                        }
                    }
                    else if (typeOfSweet == "lollipop" && storedLollipops.Count != 0)
                    {
                        for (int k = 0; k < 1; k++)
                        {
                            Income += storedLollipops[k].Price;
                            storedLollipops.Remove(storedLollipops[k]);
                        }
                    }
                }
            }
        }

        public void BuySugar(double buyableSugar)
        {
            if (Income > buyableSugar * PriceOfOneGrammSugar)
            {
                Income -= buyableSugar * PriceOfOneGrammSugar;
                AllSugar += buyableSugar;
            }
            else
            {
                Console.WriteLine("We do not have enough money to buy this amount of sugar");
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("Inventory: {0} candies, {1} lollipops, Income: {2}{3}, Sugar: {4}{5}", storedCandies.Count, storedLollipops.Count, Income, Currency, AllSugar, UnitOfMeasurementSugar);
        }
    }
}
