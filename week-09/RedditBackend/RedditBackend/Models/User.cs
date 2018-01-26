using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditBackend.Models
{
    public class User
    {
        public long UserId { get; set; }
        public string Username { get; set; }

        public List<Post> Posts { get; set; }
        public List<VoteClass> Votes { get; set; }
    }
}
