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
        private HomeRepository homeRepository;

        public PostRepository(HomeContext homeContext, HomeRepository homeRepository)
        {
            this.homeContext = homeContext;
            this.homeRepository = homeRepository;
        }

        public void AddPostToUser(User user, Post post)
        {
            post.User = homeRepository.GetCurrentUser(user);
            homeContext.RedditPosts.Add(post);
            homeContext.SaveChanges();
        }

        public List<Post> GetListOfPosts(User user)
        {
            return homeContext.RedditPosts.ToList().Where(x => x.PostId == user.UserId).ToList();
        }
    }
}
