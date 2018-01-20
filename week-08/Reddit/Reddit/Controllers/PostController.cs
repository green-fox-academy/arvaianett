//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Reddit.Repositories;
//using Reddit.Models;
//using Reddit.Services;

//// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace Reddit.Controllers
//{
//    [Route("")]
//    public class PostController : Controller
//    {
//        private PostServices postServices;
//        private HomeServices homeServices;

//        public PostController(PostServices postServices, HomeServices homeServices)
//        {
//            this.postServices = postServices;
//            this.homeServices = homeServices;
//        }

//        // GET: /<controller>/
//        [HttpGet("createpost{username}")]
//        public IActionResult Index([FromQuery]string username)
//        {
//            return View(homeServices.ViewDetails(homeServices.GetId(username)));
//        }

//        [HttpPost("add")]
//        public IActionResult AddContent(Post post, [FromQuery]string username, [FromQuery]long id)
//        {
//            postServices.AddPostToUser(id, post);
//            return Redirect($"home/{username}");
//        }
//    }
//}
