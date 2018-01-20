using Reddit2.Entities;
using Reddit2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit2.Repositories
{
    public class ContentRepository
    {
        private PostContext postContext;

        public ContentRepository(PostContext postContext)
        {
            this.postContext = postContext;
        }

        public void AddPost(Post post)
        {
            postContext.Post.Add(post);
        }
    }
}
