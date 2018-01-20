using Reddit2.Entities;
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
    }
}
