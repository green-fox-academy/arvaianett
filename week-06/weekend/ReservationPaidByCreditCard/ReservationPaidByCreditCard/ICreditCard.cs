using System;
using System.Collections.Generic;
using System.Text;

namespace ReservationPaidByCreditCard
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
