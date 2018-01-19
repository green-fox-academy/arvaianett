using Reddit.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Services
{
    public class HomeServices
    {
        private HomeRepository homeRepository;

        public HomeServices(HomeRepository homeRepository)
        {
            this.homeRepository = homeRepository;
        }

        public void AddScore(Post post)
        {
            post.Score++;
            UpdatePost(post);
        }

        public void DecreaseScore(Post post)
        {
            post.Score--;
            UpdatePost(post);
        }

        public void UpdatePost(Post post)
        {
            homeContext.RedditPosts.Update(post);
            homeContext.SaveChanges();
        }
    }
}
