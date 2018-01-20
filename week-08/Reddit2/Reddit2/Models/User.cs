using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit2.Models
{
    public class User
    {
        public long UserId { get; set; }
        public string UserName { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
