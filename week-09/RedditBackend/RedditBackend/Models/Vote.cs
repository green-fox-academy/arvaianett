using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditBackend.Models
{
    public class Vote
    {
        public long VoteId { get; set; }
        public string Score { get; set; }

        public User User { get; set; }
        public List<Post> Posts { get; set; }
    }
}
