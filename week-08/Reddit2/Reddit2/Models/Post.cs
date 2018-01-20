using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit2.Models
{
    public class Post
    {
        [Key]
        public long PostId { get; set; }
        public int Score { get; set; }
        public string Content { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;

        public User User { get; set; }
    }
}
