using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RedditBackend.Services;
using RedditBackend.Models;

namespace RedditBackend.Controllers
{
    [Route("api")]
    public class ValuesController : Controller
    {
        private PostService postService;

        public ValuesController(PostService postService)
        {
            this.postService = postService;
        }

        [HttpGet("posts")]
        public IActionResult GetPost()
        {
            return Json(new { post = postService.GetAll() });
        }

        [HttpPost("posts")]
        public IActionResult Add([FromBody]Post post)
        {
            postService.Add(post);
            return Json(new { status = "Post added" });
        }

        [HttpPut("posts/{id}/upvote")]
        public IActionResult Upvote([FromRoute]long id, [FromBody]VoteClass vote)
        {
            postService.Upvote(id, vote);
            return Json(new { status = "Post upvoted" });
        }

        [HttpPut("posts/{id}/downvote")]
        public IActionResult Downvote([FromRoute]long id, [FromBody]VoteClass vote)
        {
            postService.Downvote(id, vote);
            return Json(new { status = "Post downvoted" });
        }

        [HttpDelete("posts/{id}")]
        public IActionResult Delete([FromRoute]long id)
        {
            postService.Delete(id);
            return Json(new { status = "Post deleted" });
        }

        [HttpPut("posts/{id}")]
        public IActionResult Update([FromRoute]long id, [FromBody]Post post)
        {
            postService.Update(id, post);
            return Json(new { status = "Post updated" });
        }
    }
}
