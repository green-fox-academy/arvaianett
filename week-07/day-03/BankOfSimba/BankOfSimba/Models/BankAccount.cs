using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string Currency { get; set; }
        public string AnimalType { get; set; }
        public string Status { get; set; }
        public bool Bad_Good { get; set; }
    }
}
