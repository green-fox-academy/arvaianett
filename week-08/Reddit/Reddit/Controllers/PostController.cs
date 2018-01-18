using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reddit.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Reddit.Controllers
{
    [Route("")]
    public class PostController : Controller
    {
        private HomeRepository homeRepository;

        public PostController(HomeRepository homeRepository)
        {
            this.homeRepository = homeRepository;
        }

        // GET: /<controller>/
        [HttpGet("post")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
