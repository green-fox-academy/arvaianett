using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reddit.Repositories;
using Reddit.Models;
using Reddit.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Reddit.Controllers
{
    [Route("")]
    public class PostController : Controller
    {
        private PostServices postService;

        public PostController(PostServices postService)
        {
            this.postService = postService;
        }

        // GET: /<controller>/
        [HttpGet("createpost")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("add")]
        public IActionResult AddContent([FromQuery] Post post, User user, string username)
        {
            postService.AddPostToUser(user, post);
            return Redirect($"home/{username}");
        }
    }
}
