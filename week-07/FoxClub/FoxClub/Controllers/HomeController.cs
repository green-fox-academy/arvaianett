using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoxClub.Models;
using FoxClub.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoxClub.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public Fox fox;

        public HomeController(Fox fox)
        {
            this.fox = fox;
        }
        // GET: /<controller>/
        
        [Route("index")]
        public IActionResult Index()
        {
            return View(fox);
        }
    }
}
