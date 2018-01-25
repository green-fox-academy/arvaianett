using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditBackend.Models
{
    public class Post
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public int Timestamp { get; set; }

        public User User { get; set; }
        public Vote Votes { get; set; }
    }
}
