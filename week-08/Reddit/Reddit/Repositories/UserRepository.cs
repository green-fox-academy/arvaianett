using Reddit.Entities;
using Reddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Repositories
{
    public class UserRepository
    {
        private HomeContext homeContext;

        public UserRepository(HomeContext homeContext)
        {
            this.homeContext = homeContext;
        }

        public void UserStatus(User user)
        {
            
        }
    }
}
