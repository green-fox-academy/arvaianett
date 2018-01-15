using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TODO.Models;
using TODO.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TODO.Controllers
{
    [Route("/todo")]
    public class TodoController : Controller
    {
        private TodoRepository todoRepository;

        public TodoController(TodoRepository todoRepository)
        {
            this.todoRepository = todoRepository;
        }

        // GET: /<controller>/
        [Route("/")]
        [Route("/list")]
        public IActionResult List()
        {
            List<Todo> list = new List<Todo>();

            list.Add(new Todo()
            {
                Title = "read",
                IsUrgent = true
            });

            list.Add(new Todo()
            {
                Title = "dance",
                IsUrgent = true
            });

            list.Add(new Todo()
            {
                Title = "sing",
                IsUrgent = true
            });
            return View(list);
        }

        [HttpGet("add")]
        public IActionResult Add()
        {
            var todo = new Todo()
            {
                Title = "sleep",
                IsUrgent=false
            };
            todoRepository.Add(todo);
            return Redirect("/list");
        }
    }
}
