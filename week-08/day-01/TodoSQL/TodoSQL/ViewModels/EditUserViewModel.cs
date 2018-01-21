using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoSQL.Models;

namespace TodoSQL.ViewModels
{
    public class EditUserViewModel
    {
        public List<User> AllUser { get; set; }
        public User CurrentUser { get; set; }
    }
}
