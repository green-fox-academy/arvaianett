using Microsoft.AspNetCore.Mvc;
using Reddit.Models;
using Reddit.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Reddit.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        private HomeServices homeServices;

        public HomeController(HomeServices homeServices)
        {
            this.homeServices = homeServices;
        }

        // GET: /<controller>/
        [HttpGet("{username}")]
        public IActionResult Index([FromRoute]string username)
        {
            return View(homeServices.ViewDetails(homeServices.GetId(username)));
        }

        //[HttpPost("score_add")]
        //public IActionResult AddScore(Post post)
        //{
        //    homeRepository.AddScore(post);
        //    return Redirect("home");
        //}

        //[HttpPost("score_decrease")]
        //public IActionResult DecreaseScore(Post post)
        //{
        //    homeRepository.DecreaseScore(post);
        //    return Redirect("home");
        //}
    }
}
