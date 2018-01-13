using FoxClub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.ViewModel
{
    public class FoxViewModel
    {
        public List<Fox> foxList = new List<Fox>();

        public FoxViewModel()
        {
            InitFoxList();
        }

        public void InitFoxList()
        {
            foxList.Add(new Fox()
            {
                Name = "Vuk",
                Food = "Salad",
                Drink = "Water",
            });
        }
    }
}
