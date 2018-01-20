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
    public class ContentController : Controller
    {
        private ContentService contentService;

        public ContentController(ContentService contentService)
        {
            this.contentService = contentService;
        }

        // GET: /<controller>/
        [HttpGet("addcontent/{username}")]
        public IActionResult Content()
        {
            return View();
        }

        [HttpGet("add")]
        public IActionResult AddPost(Post post, [FromBody]string username)
        {
            contentService.AddPost(post);
            return Redirect($"posts/{username}");
        }
    }
}
