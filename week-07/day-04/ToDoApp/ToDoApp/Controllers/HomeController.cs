using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.ViewModel;
using ToDoApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoApp.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public ToDoViewModel toDoViewModel;

        public HomeController(ToDoViewModel toDoViewModel)
        {
            this.toDoViewModel = toDoViewModel;
        }
        // GET: /<controller>/
        [HttpGet("")]
        public IActionResult Index()
        {
            return View(toDoViewModel);
        }

        [HttpPost("add")]
        public IActionResult AddTask(ToDo todo)
        {
            toDoViewModel.todoList.Add(todo);

            return RedirectToAction("index");
        }

        [HttpPost("remove")]
        public IActionResult RemoveTask(int item)
        {
            //var delete = toDoViewModel.todoList[item];
            //toDoViewModel.todoList.Remove(delete);
            return RedirectToAction("index");
        }
    }
}
