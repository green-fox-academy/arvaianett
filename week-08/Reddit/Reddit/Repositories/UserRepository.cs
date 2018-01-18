using Reddit.Entities;
using Reddit.Models;
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

        public void UserStatus(User user)
        {
            if (homeContext.RedditUsers.ToList().Contains(user))
            {
                GetUserData(user);
            }
            else
            {
                AddUser(user);
            }
        }

        public void AddUser(User user)
        {
            homeContext.RedditUsers.Add(user);
            homeContext.SaveChanges();
        }

        public User GetUserData(User user)
        {
            return homeContext.RedditUsers.FirstOrDefault(x => x.UserId == user.UserId);
        }
    }
}
