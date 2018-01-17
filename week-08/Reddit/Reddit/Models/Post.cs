using System.ComponentModel.DataAnnotations;

namespace Reddit.Models
{
    public class Post
    {
        [Key]
        public long PostId { get; set; }
        public int Score { get; set; }
        public string Content { get; set; }

        public User User { get; set; }
    }
}
