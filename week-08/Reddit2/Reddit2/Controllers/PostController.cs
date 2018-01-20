using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reddit2.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Reddit2.Controllers
{
    [Route("")]
    public class PostController : Controller
    {
        private PostService postService;

        public PostController(PostService postService)
        {
            this.postService = postService;
        }

        // GET: /<controller>/
        [HttpGet("posts")]
        public IActionResult Index()
        {
            return View(postService.GetAll());
        }

        [HttpGet("addscore")]
        public IActionResult AddScore(long id)
        {
            postService.AddScore(id);
            return Redirect("posts");
        }

        [HttpGet("decreasescrore")]
        public IActionResult DecreaseScore(long id)
        {
            postService.DecreaseScore(id);
            return Redirect("posts");
        }
    }
}
