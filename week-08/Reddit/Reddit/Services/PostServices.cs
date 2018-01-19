using Reddit.Models;
using Reddit.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Services
{
    public class PostServices
    {
        public PostRepository postRepository;

        public PostServices(PostRepository postRepository)
        {
            this.postRepository = postRepository;
        }
    }
}
