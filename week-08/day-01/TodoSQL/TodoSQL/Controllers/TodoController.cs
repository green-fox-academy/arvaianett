using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoSQL.Repositories;
using TodoSQL.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoSQL.Controllers
{
    [Route("")]
    public class TodoController : Controller
    {
        TodoRepository todoRepository;

        public TodoController(TodoRepository todoRepository)
        {
            this.todoRepository = todoRepository;
        }

        // GET: /<controller>/
        [Route("todo")]
        public IActionResult Index()
        {
            return View(todoRepository);
        }

        [Route("/list")]
        public IActionResult List()
        {
            return View(todoRepository.GetAll());
        }

        [HttpPost("add")]
        public IActionResult AddElement(Todo todo)
        {
            todoRepository.Add(todo);
            
            return Redirect("/list");
        }
    }
}
