using Reddit.Entities;
using Reddit.Models;
using Reddit.Repositories;
using Reddit.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Services
{
    public class HomeServices
    {
        private HomeRepository homeRepository;
        private PostRepository postRepository;

        public HomeServices(HomeRepository homeRepository, PostRepository postRepository)
        {
            this.homeRepository = homeRepository;
            this.postRepository = postRepository;
        }

        public HomeViewModel ViewDetails(User user)
        {
            return new HomeViewModel()
            {
                User = homeRepository.GetCurrentUser(user),
                Post = postRepository.GetListOfPosts(user)
            };
        }

        //public void AddScore(Post post)
        //{
        //    post.Score++;
        //    UpdatePost(post);
        //}

        //public void DecreaseScore(Post post)
        //{
        //    post.Score--;
        //    UpdatePost(post);
        //}

        //public void UpdatePost(Post post)
        //{
        //    homeContext.RedditPosts.Update(post);
        //    homeContext.SaveChanges();
        //}
    }
}
