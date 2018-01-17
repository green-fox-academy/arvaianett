using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoSQL.Entities;
using TodoSQL.Models;

namespace TodoSQL.Repositories
{
    public class UserRepository
    {
        private TodoContext todoContext;

        public UserRepository(TodoContext todoContext)
        {
            this.todoContext = todoContext;
        }

        public List<User> GetAll()
        {
            return todoContext.Users.ToList();
        }
    }
}
