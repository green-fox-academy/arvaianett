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
            return View();
        }

        [Route("/list")]
        public IActionResult List([FromQuery] Todo todo)
        {
            return View(todoRepository.GetAll());
        }

        [HttpPost("add")]
        public IActionResult AddElement(Todo todo)
        {
            todoRepository.Add(todo);
            return Redirect("/list");
        }

        [HttpGet("/{id}/delete")]
        public IActionResult Delete(long id)
        {
            todoRepository.Delete(id);
            return Redirect("/list");
        }

        [HttpGet("/{id}/edit")]
        public IActionResult Update(long id)
        {
            return View(todoRepository.GetEditView(id));
        }

        [HttpPost("/{id}/edit/update")]
        public IActionResult Edit(Todo todo)
        {
            todoRepository.Edit(todo);
            return Redirect("/list");
        }

        [HttpPost("search")]
        public IActionResult Search(string searchTerm)
        {
            todoRepository.Search(searchTerm);
            return Redirect("/list");
        }
    }
}
