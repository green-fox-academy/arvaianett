using System;
using System.Collections.Generic;

namespace ReservationPaidByCreditCard
{
    class Program
    {
        static void Main(string[] args)
        {
            var creditCardReservation = new List<CreditCardReservation>();

            for (int i = 1; i < 10; i++)
            {
                creditCardReservation.Add(new CreditCardReservation("DEF" + i.ToString()));
            }

            foreach (var card in creditCardReservation)
            {
                Console.WriteLine(card.Tostring());
            }

            Console.ReadLine();
        }
    }
}
