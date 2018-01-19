using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reddit.Repositories;
using Reddit.Models;
using Reddit.ViewModels;
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
        public IActionResult Index([FromQuery]User user)
        {
            return View(homeServices.ViewDetails(user));
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
