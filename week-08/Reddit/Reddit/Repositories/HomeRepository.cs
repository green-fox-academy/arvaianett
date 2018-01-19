using Microsoft.EntityFrameworkCore;
using Reddit.Entities;
using Reddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Repositories
{
    public class HomeRepository
    {
        private HomeContext homeContext;

        public HomeRepository(HomeContext homeContext)
        {
            this.homeContext = homeContext;
        }

        public User GetCurrentUser(long id)
        {
            homeContext.RedditPosts.Load();
            return homeContext.RedditUsers.FirstOrDefault(u => u.UserId.Equals(id));
        }

        public long GetId(string username)
        {
            User user = homeContext.RedditUsers.FirstOrDefault(u => u.Username.Equals(username));
            return user.UserId;
        }
    }
}
