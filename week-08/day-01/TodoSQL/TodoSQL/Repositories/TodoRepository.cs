using System.Collections.Generic;
using System.Linq;
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
            Todo todo = todoContext.Todos.FirstOrDefault(x => x.TodoId == id);
            todoContext.Todos.Remove(todo);
            todoContext.SaveChanges();
        }

        public Todo GetEditView(long id)
        {
            return todoContext.Todos.FirstOrDefault(x => x.TodoId == id);
        }

        public void Edit(Todo todo)
        {
            todoContext.Todos.Update(todo);
            todoContext.SaveChanges();
        }

        public List<Todo> Search(string searchTerm)
        {
            return todoContext.Todos.Where(t => t.Content == searchTerm || t.Description == searchTerm || t.Title == searchTerm).ToList();
        }
    }
}
