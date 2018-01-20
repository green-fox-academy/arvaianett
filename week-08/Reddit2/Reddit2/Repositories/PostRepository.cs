using Reddit2.Entities;
using Reddit2.Models;
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

        public List<Post> GetAll()
        {
            return postContext.Post.ToList();
        }

        public Post GetItem(long id)
        {
            return postContext.Post.FirstOrDefault(s=>s.PostId == id);
        }
    }
}
