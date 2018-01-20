//using Reddit.Models;
//using Reddit.Repositories;
//using Reddit.ViewModels;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Reddit.Services
//{
//    public class PostServices
//    {
//        public PostRepository postRepository;
//        public HomeRepository homeRepository;

//        public PostServices(PostRepository postRepository, HomeRepository homeRepository)
//        {
//            this.postRepository = postRepository;
//            this.homeRepository = homeRepository;
//        }

//        public HomeViewModel ViewDetails(long id)
//        {
//            return new HomeViewModel()
//            {
//                User = homeRepository.GetCurrentUser(id),
//                Post = postRepository.GetListOfPosts(id)
//            };
//        }

//        public void AddPostToUser(long id, Post post)
//        {
//            postRepository.AddPostToUser(id, post);
//        }
//    }
//}
