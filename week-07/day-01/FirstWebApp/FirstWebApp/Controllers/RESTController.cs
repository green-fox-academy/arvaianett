using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstWebApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstWebApp.Controllers
{
    public class RESTController : Controller
    {
        // GET: /<controller>/
        [Route("api")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("greeting")]
        public IActionResult Greeting(string name)
        {
            return new JsonResult(new { Id = 3, Name = name });
        }
    }
}
