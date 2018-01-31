using PallidaRetake.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PallidaRetake.ViewModels
{
    public class WebshopViewModel
    {
        public List<string> FilteredByName { get; set; }
        public List<string> FilteredBySize { get; set; }
        public List<Clothes> AllClothes { get; set; }
        public Clothes SelectedClothes { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
