using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReservationPaidByCreditCard
{
    class CreditCardReservation : ICreditCard, IReservations
    {
        Random randomNumber = new Random();
        private const int CodeLength = 16;
        public int CVV { get; set; }
        public string CC { get; set; }
        public string DOW { get; set; }
        public string Code { get; set; }
        public string name;
        
        public CreditCardReservation(string name)
        {
            this.name = name;
            CVV = GetSumCVV();
            CC = GetCodeAccount();
            DOW = GetDowBooking();
            Code = GetCodeBooking();
        }

        public int CumeSumCVV(string codeAccount)
        {
            int CVV = 0;

            for (int i = 0; i < codeAccount.Length - 1; i++)
            {
                CVV += int.Parse(codeAccount[i].ToString());
            }

            return CVV;
        }

        public string GetCodeAccount()
        {
            var codeNumbers = new List<int>();

            for (int i = 0; i < CodeLength; i++)
            {
                codeNumbers.Add(randomNumber.Next(10));
            }

            var builder = new StringBuilder();

            string code = string.Empty;

            for (int i = 0; i < codeNumbers.Count; i++)
            {
                code = builder.Append(codeNumbers[i]).ToString();
            }

            return code;
        }

        public string GetCodeBooking()
        {
            List<string> characters = new List<string>();

            char[] alphabet = Enumerable.Range('A', 26).Select(x => (char)x).ToArray();

            int[] numbersZeroToNine = Enumerable.Range(0, 10).Select(x => (int)x).ToArray();

            for (int i = 0; i < alphabet.Length; i++)
            {
                characters.Add(alphabet[i].ToString());
            }

            for (int i = 0; i < numbersZeroToNine.Length; i++)
            {
                characters.Add(numbersZeroToNine[i].ToString());
            }

            List<string> reservation = new List<string>();

            for (int i = 0; i < 7; i++)
            {
                int r = randomNumber.Next(characters.Count);

                reservation.Add(characters[r]);
            }

            StringBuilder builder = new StringBuilder();

            string res = "";

            for (int i = 0; i < reservation.Count; i++)
            {
                res = builder.Append(reservation[i]).ToString();
            }

            return res;
        }

        public string GetDowBooking()
        {
            List<string> days = new List<string>()
            {
                "MON",
                "TUE",
                "WED",
                "THU",
                "FRI",
                "SAT",
                "SUN"
            };

            int randomIndex = randomNumber.Next(days.Count);

            return days[randomIndex];
        }

        public string GetNameCardholder()
        {
            return name;
        }

        public int GetSumCVV()
        {
            return CumeSumCVV(GetCodeAccount());
        }

        public string Tostring()
        {
            return "Booking# " + Code + " for " + DOW +  " paid by Name=" + name + " CC#=" + CC + " CVV=" + CVV;
        }
    }
}
