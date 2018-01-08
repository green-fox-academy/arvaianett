using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstWebApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstWebApp.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        private static long Id { get; set; }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [Route("greeting")]
        
        public IActionResult Greeting(string name)
        {
            Id++;

            return new JsonResult(new Greeting(Id, name));
        }
    }
}
