using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCard
{
    interface ICreditCard
    {
        int GetSumCVV();

        string GetNameCardholder();

        string GetCodeAccount();

        int CumeSumCVV(string codeAccount);

        string Tostring();
    }
}
