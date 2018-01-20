using Reddit2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit2.ViewModels
{
    public class PostViewModel
    {
        public List<Post> AllPosts { get; set; }
        public List<Post> BestTen { get; set; }
        public User User { get; set; }
    }
}
