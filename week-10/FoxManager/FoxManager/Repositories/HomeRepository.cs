using FoxManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxManager.Repositories
{
    public class HomeRepository
    {
        private FoxContext foxContext;

        public HomeRepository(FoxContext foxContext)
        {
            this.foxContext = foxContext;
        }
    }
}
