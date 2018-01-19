using Reddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.ViewModels
{
    public class HomeViewModel
    {
        public Post Post { get; set; }
        public User user { get; set; }
    }
}
