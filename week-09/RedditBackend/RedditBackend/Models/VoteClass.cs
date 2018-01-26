using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RedditBackend.Models
{
    public class VoteClass
    {
        [Key]
        public long VoteId { get; set; }
        public int Vote { get; set; }

        public User User { get; set; }
    }
}
