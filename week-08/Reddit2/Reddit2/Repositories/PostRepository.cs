using Reddit2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit2.Repositories
{
    public class PostRepository
    {
        private PostContext postContext;

        public PostRepository(PostContext postContext)
        {
            this.postContext = postContext;
        }
    }
}
