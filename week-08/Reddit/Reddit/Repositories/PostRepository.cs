using Reddit.Entities;
using Reddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Repositories
{
    public class PostRepository
    {
        private HomeContext homeContext;

        public PostRepository(HomeContext homeContext)
        {
            this.homeContext = homeContext;
        }

        public void AddContent(Post post)
        {
            homeContext.RedditPosts.Add(post);
            homeContext.SaveChanges();
        }

        public List<Post> GetListOfPosts(User user)
        {
            return homeContext.RedditPosts.ToList().Where(x => x.PostId == user.UserId).ToList();
        }
    }
}
