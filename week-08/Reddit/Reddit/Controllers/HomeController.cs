using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reddit.Repositories;
using Reddit.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Reddit.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private HomeRepository homeRepository;

        public HomeController(HomeRepository homeRepository)
        {
            this.homeRepository = homeRepository;
        }

        // GET: /<controller>/
        [HttpGet("home")]
        public IActionResult Index()
        {
            return View(homeRepository);
        }

        [HttpPost("score_add")]
        public IActionResult AddScore(Post post)
        {
            homeRepository.AddScore(post);
            return Redirect("posts");
        }

        [HttpPost("score_decrease")]
        public IActionResult DecreaseScore(Post post)
        {
            homeRepository.DecreaseScore(post);
            return Redirect("posts");
        }
    }
}
