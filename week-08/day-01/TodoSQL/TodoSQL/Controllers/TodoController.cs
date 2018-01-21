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
        UserRepository userRepository;

        public TodoController(TodoRepository todoRepository, UserRepository userRepository)
        {
            this.todoRepository = todoRepository;
            this.userRepository = userRepository;
        }

        // GET: /<controller>/
        [Route("todo")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/list")]
        public IActionResult List()
        {
            return View(userRepository.GetView());
        }

        [HttpPost("add")]
        public IActionResult AddElement(Todo todo, User user)
        {
            todoRepository.Add(todo, user);
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
        public IActionResult Edit(Todo todo, [FromRoute]long id)
        {
            todoRepository.Edit(todo, id);
            return Redirect("/list");
        }
    }
}
