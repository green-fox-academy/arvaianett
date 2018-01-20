using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reddit2.Services;
using Reddit2.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Reddit2.Controllers
{
    [Route("addcontent")]
    public class ContentController : Controller
    {
        private ContentService contentService;
        private PostService postService;

        public ContentController(ContentService contentService, PostService postService)
        {
            this.contentService = contentService;
            this.postService = postService;
        }

        // GET: /<controller>/
        [HttpGet("{username}")]
        public IActionResult ContentIndex([FromRoute]string username)
        {
            return View(postService.GetListForView(postService.GetId(username)));
        }

        [HttpPost("add/{username}")]
        public IActionResult AddPost(Post post, string username)
        {
            contentService.AddPost(post);
            return Redirect($"posts/{username}");
        }
    }
}
