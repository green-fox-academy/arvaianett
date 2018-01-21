using Microsoft.EntityFrameworkCore;
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

        public List<Todo> GetAllTodos()
        {
            return todoContext.Todos.ToList();
        }

        public TodoViewModel GetView()
        {
            return new TodoViewModel()
            {
                Users = GetAll(),
                AllTodos = GetAllTodos()
            };
        }

        public void AddUser(User user)
        {
            todoContext.Users.Add(user);
            todoContext.SaveChanges();
        }

        public void DeleteUser(long id)
        {
            User user = todoContext.Users.FirstOrDefault(u => u.UserId == id);
            todoContext.Users.Remove(user);
            todoContext.SaveChanges();
        }

        public List<User> GetUserView()
        {
            return todoContext.Users.ToList();
        }

        public User GetCurrentUser(long id)
        {
            return todoContext.Users.FirstOrDefault(u => u.UserId == id);
        }

        public EditUserViewModel EditUserView(long id)
        {
            return new EditUserViewModel()
            {
                AllUser = GetUserView(),
                CurrentUser = GetCurrentUser(id)
            };
        }

        public void UpdateUser(User user, long id)
        {
            todoContext.Users.Update(user);
            todoContext.SaveChanges();
        }

        public User GetAssignee(string name)
        {
            return todoContext.Users.FirstOrDefault(a => a.Name == name);
        }

        public List<Todo> GetAssigneeTodos(string name)
        {
            return todoContext.Todos.Where(t => t.User.Name == name).ToList();
        }

        public AssigneesTodoListViewModel GetAssigneesTodoView(string name)
        {
            return new AssigneesTodoListViewModel()
            {
                AssigneesTodoList = GetAssigneeTodos(name),
                CurrentUser = GetAssignee(name)
            };
        }
    }
}
