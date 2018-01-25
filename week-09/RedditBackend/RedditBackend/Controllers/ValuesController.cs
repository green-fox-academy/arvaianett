using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RedditBackend.Controllers
{
    [Route("api")]
    public class ValuesController : Controller
    {
        [HttpGet("posts")]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpPost("posts")]
        public IActionResult Post()
        {
            return Ok();
        }

        [HttpPut("posts/{id}/upvote")]
        public IActionResult Upvote()
        {
            return Ok();
        }

        [HttpPut("posts/{id}/downvote")]
        public IActionResult Downvote()
        {
            return Ok();
        }

        [HttpDelete("posts/{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }

        [HttpPut("posts/{id}")]
        public IActionResult Method()
        {
            return Ok();
        }
    }
}
