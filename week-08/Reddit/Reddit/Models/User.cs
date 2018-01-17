using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Reddit.Models
{
    public class User
    {
        [Key]
        public long UserId { get; set; }
        public string Username { get; set; }

        public ICollection<Post> Post { get; set; }
    }
}
