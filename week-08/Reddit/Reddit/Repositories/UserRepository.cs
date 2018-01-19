using Reddit.Entities;
using Reddit.Models;
using Reddit.ViewModels;
using System.Linq;

namespace Reddit.Repositories
{
    public class UserRepository
    {
        private HomeContext homeContext;

        public UserRepository(HomeContext homeContext)
        {
            this.homeContext = homeContext;
        }

        public bool UserStatus(string username)
        {
            return homeContext.RedditUsers.Where(u => u.Username.Equals(username)).Count() > 0;
        }

        public void AddUser(string username)
        {
            homeContext.RedditUsers.Add(new User()
            {
                Username = username
            });

            homeContext.SaveChanges();
        }
    }
}
