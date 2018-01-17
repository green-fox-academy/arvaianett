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

        public void Delete(long id)
        {
            Todo todo = todoContext.Todos.FirstOrDefault(x => x.Id == id);
            todoContext.Todos.Remove(todo);
            todoContext.SaveChanges();
        }

        public Todo GetEditView(long id)
        {
            return todoContext.Todos.FirstOrDefault(x => x.Id == id);
        }

        public void Edit(Todo todo, long id)
        {
            todoContext.Todos.Update(todo);
            todoContext.SaveChanges();
        }

        public List<Todo> IsActive()
        {
            var activeTodo = new List<Todo>();

            foreach (var item in todoContext.Todos.ToList())
            {
                if(item.IsDone == false)
                {
                    activeTodo.Add(item);
                }
            }
            return activeTodo;
        }
    }
}
