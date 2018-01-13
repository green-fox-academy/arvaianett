using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Models;

namespace ToDoApp.ViewModel
{
    public class ToDoViewModel
    {
        public List<ToDo> todoList = new List<ToDo>();

        public ToDoViewModel()
        {
            InitTodoList();
        }

        public void InitTodoList()
        {
            todoList.Add(new ToDo()
            {
                Task = "wake up",
                Done = true
            });

            todoList.Add(new ToDo()
            {
                Task = "drink tea"
            });

            todoList.Add(new ToDo()
            {
                Task = "sleep",
                Urgent = true
            });
        }

        public List<ToDo> Remove(int index)
        {
            todoList.RemoveAt(index);

            return todoList;
        }
    }
}
