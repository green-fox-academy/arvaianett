using BankOfSimba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.ViewModels
{
    public class BankAccountViewModel
    {
        public List<BankAccount> BankAccountList = new List<BankAccount>();

        public BankAccountViewModel()
        {
            InitAccountList();
        }

        public void InitAccountList()
        {
            BankAccountList.Add(new BankAccount()
            {
                Name = "Simba",
                Balance = 2000.00,
                Currency = "Zebra",
                AnimalType = "Lion",
                Status = "King",
                Bad_Good = true
            });

            BankAccountList.Add(new BankAccount()
            {
                Name = "Scar",
                Balance = 1000.00,
                Currency = "Zebra",
                AnimalType = "Lion",
                Bad_Good = false
            });

            BankAccountList.Add(new BankAccount()
            {
                Name = "Zazu",
                Balance = 500.50,
                Currency = "Zebra",
                AnimalType = "Parrot",
                Bad_Good = true
            });

            BankAccountList.Add(new BankAccount()
            {
                Name = "Nala",
                Balance = 900.00,
                Currency = "Zebra",
                AnimalType = "Lion",
                Bad_Good = true
            });
        }
    }
}
