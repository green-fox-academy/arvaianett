using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoSQL.Models;

namespace TodoSQL.ViewModels
{
    public class TodoViewModel
    {
        public List<Todo> AllTodos { get; set; }
        public List<Todo> SearchedTodos { get; set; }
    }
}
