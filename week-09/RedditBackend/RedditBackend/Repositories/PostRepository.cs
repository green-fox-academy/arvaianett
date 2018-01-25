using RedditBackend.Entities;
using RedditBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditBackend.Repositories
{
    public class PostRepository
    {
        private RedditContext redditContext;

        public PostRepository(RedditContext redditContext)
        {
            this.redditContext = redditContext;
        }

        public Post GetPost(long id)
        {
            return redditContext.Posts.FirstOrDefault(p => p.Id == id);
        }

        public void Add(Post post)
        {
            redditContext.Posts.Add(post);
            redditContext.SaveChanges();
        }

        public void Upvote(long id)
        {
            Post post = GetPost(id);
            post.Score += 1;
            redditContext.SaveChanges();
        }

        public void Downvote(long id)
        {
            Post post = GetPost(id);
            post.Score -= 1;
            redditContext.SaveChanges();
        }

        public void Delete(long id)
        {
            Post post = GetPost(id);
            redditContext.Posts.Remove(post);
            redditContext.SaveChanges();
        }

        public void Update(long id, Post post)
        {
            redditContext.Update(post);
            redditContext.SaveChanges();
        }
    }
}
