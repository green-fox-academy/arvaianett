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
        private PostRepository postRepository;

        public HomeController(HomeRepository homeRepository, PostRepository postRepository)
        {
            this.homeRepository = homeRepository;
            this.postRepository = postRepository;
        }

        // GET: /<controller>/
        [HttpGet("home")]
        public IActionResult Index([FromQuery]User user)
        {
            postRepository.GetListOfPosts(user);
            homeRepository.GetCurrentUser(user);
            return View();
        }

        [HttpPost("score_add")]
        public IActionResult AddScore(Post post)
        {
            homeRepository.AddScore(post);
            return Redirect("home");
        }

        [HttpPost("score_decrease")]
        public IActionResult DecreaseScore(Post post)
        {
            homeRepository.DecreaseScore(post);
            return Redirect("home");
        }
    }
}
