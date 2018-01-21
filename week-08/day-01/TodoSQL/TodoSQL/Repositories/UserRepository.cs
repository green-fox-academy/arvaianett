using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoSQL.Entities;
using TodoSQL.Models;
using TodoSQL.ViewModels;

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

        public TodoViewModel GetView()
        {
            return new TodoViewModel()
            {
                Users = GetAll()
            };
        }

        public void AddUser(User user)
        {
            todoContext.Users.Add(user);
            todoContext.SaveChanges();
        }
    }
}
