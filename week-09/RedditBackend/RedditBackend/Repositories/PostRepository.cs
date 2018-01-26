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

        public List<Post> GetAll()
        {
            return redditContext.Posts.ToList();
        }

        public Post GetPost(long id)
        {
            return redditContext.Posts.FirstOrDefault(p => p.Id == id);
        }

        public string GetUserName(long id)
        {
            return redditContext.Users.FirstOrDefault(u => u.UserId == id).Username;
        }

        public void Add(Post post)
        {
            
            var addPostWithUser = new Post()
            {
                Id = post.Id,
                Title = post.Title,
                Url = post.Url,
                Timestamp = post.Timestamp,
                User = post.User
            };

            redditContext.Posts.Add(addPostWithUser);
            redditContext.SaveChanges();
        }

        public void Upvote(long id, VoteClass vote)
        {
            Post post = GetPost(id);
            post.Score++;
            redditContext.SaveChanges();
        }

        public void Downvote(long id, VoteClass vote)
        {
            Post post = GetPost(id);
            post.Score--;
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
