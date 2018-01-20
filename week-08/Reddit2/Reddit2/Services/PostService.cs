using Reddit2.Models;
using Reddit2.Repositories;
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
    }
}
