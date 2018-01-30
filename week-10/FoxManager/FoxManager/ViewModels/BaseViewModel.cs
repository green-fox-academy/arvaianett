using FoxManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxManager.ViewModels
{
    public class BaseViewModel
    {
        public ClassViewModel ClassViewModel { get; set; }
        public HomeViewModel HomeViewModel { get; set; }
        public TeamViewModel TeamViewModel { get; set; }
        public Student CurrentStudent { get; set; }
    }
}
