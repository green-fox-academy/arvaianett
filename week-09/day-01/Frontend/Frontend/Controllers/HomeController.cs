using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Frontend.Controllers
{
    public class HomeController : Controller
    {
        // GET api/values
        [Route("")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }
    }
}
