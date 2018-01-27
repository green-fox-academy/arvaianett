using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoxManager.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoxManager.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private HomeService homeService;

        public HomeController(HomeService homeService)
        {
            this.homeService = homeService;       
        }

        // GET: /<controller>/
        [HttpGet("home")]
        public IActionResult Home()
        {
            return View("home", "_layout");
        }
    }
}
