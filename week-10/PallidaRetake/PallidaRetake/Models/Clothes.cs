using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PallidaRetake.Models
{
    public class Clothes
    {
        public long Id { get; set; }
        public string ItemName { get; set; }
        public string Manufacturer { get; set; }
        public string Catergory { get; set; }
        public string Size { get; set; }
        public double UnitPrice { get; set; }
    }
}
