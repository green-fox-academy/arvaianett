using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreditCard
{
    public class CreditCard : ICreditCard
    {
        Random randomNumber = new Random();
        private const int CodeLength = 16;
        public int CVV { get; set; }
        public string CC { get; set; }
        public string name;

        public CreditCard(string name)
        {
            this.name = name;
            CVV = GetSumCVV();
            CC = GetCodeAccount();
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
            return "Name=" + name + " CC#=" + CC + " CVV=" + CVV + " (validated)";
        }
    }
}
