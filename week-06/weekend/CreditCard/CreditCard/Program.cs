using System;
using System.Collections.Generic;

namespace CreditCard
{
    class Program
    {
        static void Main(string[] args)
        {
            var cardList = new List<CreditCard>();

            for (int i = 1; i < 10; i++)
            {
                cardList.Add(new CreditCard("ABC" + i.ToString()));
            }

            foreach (var card in cardList)
            {
                Console.WriteLine(card.Tostring());
            }

            Console.ReadLine();
        }
    }
}
