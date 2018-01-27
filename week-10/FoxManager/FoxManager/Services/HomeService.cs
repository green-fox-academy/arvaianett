using FoxManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxManager.Services
{
    public class HomeService
    {
        private HomeRepository homeRepository;

        public HomeService(HomeRepository homeRepository)
        {
            this.homeRepository = homeRepository;
        }
    }
}
