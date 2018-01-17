using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Models
{
    public class User
    {
        public long UserId { get; set; }
        public string Username { get; set; }

        public ICollection<Post> Post { get; set; }
    }
}
