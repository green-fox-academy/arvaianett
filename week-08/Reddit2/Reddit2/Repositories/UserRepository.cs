using Reddit2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit2.Repositories
{
    public class UserRepository
    {
        private PostContext postContext;

        public UserRepository(PostContext postContext)
        {
            this.postContext = postContext;
        }
    }
}
