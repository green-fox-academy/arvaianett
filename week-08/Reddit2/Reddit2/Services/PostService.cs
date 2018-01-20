using Reddit2.Models;
using Reddit2.Repositories;
using Reddit2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit2.Services
{
    public class PostService
    {
        private PostRepository postRepository;

        public PostService(PostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

        public List<Post> GetAll()
        {
            return postRepository.GetAll();
        }

        public void AddScore(long id)
        {
            postRepository.AddScore(id);
        }

        public void DecreaseScore(long id)
        {
            postRepository.DecreaseScore(id);
        }

        public List<Post> BestTen()
        {
            return postRepository.BestTen();
        }

        //public List<List<Post>> Lists()
        //{
        //    List<List<Post>> list = new List<List<Post>>();
        //    list.Add(postRepository.GetAll());
        //    list.Add(postRepository.BestTen());
        //    return list;
        //}

        public PostViewModel GetListForView()
        {
            return new PostViewModel()
            {
                AllPosts = GetAll(),
                BestTen = BestTen()
            };
        }
    }
}
