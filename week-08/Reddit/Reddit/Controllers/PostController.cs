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
    public class PostController : Controller
    {
        private PostRepository postRepository;

        public PostController(PostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

        // GET: /<controller>/
        [HttpGet("createpost")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("add")]
        public IActionResult AddContent(Post post, string username)
        {
            postRepository.AddContent(post);
            return Redirect($"home/{username}");
        }
    }
}
