//using Reddit.Entities;
//using Reddit.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Reddit.Repositories
//{
//    public class PostRepository
//    {
//        private HomeContext homeContext;
//        private HomeRepository homeRepository;

//        public PostRepository(HomeContext homeContext, HomeRepository homeRepository)
//        {
//            this.homeContext = homeContext;
//            this.homeRepository = homeRepository;
//        }

//        public void AddPostToUser(long id, Post post)
//        {
//            post.User = homeRepository.GetCurrentUser(id);
//            homeContext.RedditPosts.Add(post);
//            homeContext.SaveChanges();
//        }

//        public List<Post> GetListOfPosts(long id)
//        {
//            return homeContext.RedditPosts.Where(u => u.PostId == id).ToList();
//        }
//    }
//}
