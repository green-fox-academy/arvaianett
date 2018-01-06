using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reservations
{
    public class Reservation : IReservationy
    {
        Random random = new Random();

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
                int r = random.Next(characters.Count);

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

            int randomIndex = random.Next(days.Count);

            return days[randomIndex];
        }
    }
}
