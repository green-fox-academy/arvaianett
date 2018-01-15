using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoSQL.Entities;
using TodoSQL.Models;

namespace TodoSQL.Repositories
{
    public class TodoRepository
    {
        private TodoContext todoContext;

        public TodoRepository(TodoContext todoContext)
        {
            this.todoContext = todoContext;
        }

        public void Add(Todo todo)
        {
            todoContext.Todos.Add(todo);
            todoContext.SaveChanges();
        }

        public List<Todo> GetAll()
        {
            return todoContext.Todos.ToList();
        }
    }
}
