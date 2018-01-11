using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GreetSomeone.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GreetSomeone.Controllers
{
    public class GreetController : Controller
    {
        public GreetModel greetModel;

        public GreetController(GreetModel greetModel)
        {
            this.greetModel = greetModel;
        }
        // GET: /<controller>/
        [HttpGet("")]
        public IActionResult Index()
        {
            return View(greetModel);
        }

        [HttpPost("add")]
        public IActionResult PostMethod(string name)
        {
            greetModel.Name = name;
            return RedirectToAction("Greet");
        }

        [HttpGet("greet")]
        public IActionResult Greet()
        {
            return View(greetModel);
        }
    }
}
