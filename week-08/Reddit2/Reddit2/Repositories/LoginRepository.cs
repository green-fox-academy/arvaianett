using Reddit2.Entities;
using Reddit2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit2.Repositories
{
    public class LoginRepository
    {
        private PostContext postContext;

        public LoginRepository(PostContext postContext)
        {
            this.postContext = postContext;
        }

        public bool UserStatus(string username)
        {
            return postContext.Users.Where(u => u.UserName.Equals(username)).Count() > 0;
        }

        public void AddUser(string username)
        {
            postContext.Users.Add(new User()
            {
                UserName = username
            });

            postContext.SaveChanges();
        }
    }
}
