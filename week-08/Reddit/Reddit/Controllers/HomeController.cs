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
        private PostRepository postRepository;

        public HomeController(PostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

        // GET: /<controller>/
        [HttpGet("posts")]
        public IActionResult Index()
        {
            return View(postRepository);
        }

        [HttpPost("score_add")]
        public IActionResult AddScore(Post post)
        {

        }

        [HttpPost("score_decrease")]
        public IActionResult DecreaseScore(Post post)
        {

        }

        //[HttpPost("createpost")]
        //public IActionResult CreatePost()
        //{
        //    return Ok();
        //}
    }
}
