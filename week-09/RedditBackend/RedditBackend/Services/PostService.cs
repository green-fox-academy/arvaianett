using RedditBackend.Models;
using RedditBackend.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditBackend.Services
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

        public Post GetPost(long id)
        {
            return postRepository.GetPost(id);
        }

        public string GetUserName(long id)
        {
            return postRepository.GetUserName(id);
        }

        public void Add(Post post)
        {
            postRepository.Add(post);
        }

        public void Upvote(long id, VoteClass vote)
        {
            postRepository.Upvote(id, vote);
        }

        public void Downvote(long id, VoteClass vote)
        {
            postRepository.Downvote(id, vote);
        }

        public void Delete(long id)
        {
            postRepository.Delete(id);
        }

        public void Update(long id, Post post)
        {
            postRepository.Update(id, post);
        }
    }
}
