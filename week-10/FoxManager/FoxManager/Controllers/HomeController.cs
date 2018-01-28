using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoxManager.Services;
using FoxManager.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoxManager.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private HomeService homeService;

        public HomeController(HomeService homeService)
        {
            this.homeService = homeService;       
        }

        // GET: /<controller>/
        [HttpGet("home/{name}")]
        public IActionResult Home([FromRoute]string name)
        {
            return View(homeService.GetHomeView(name));
        }

        [HttpPost("add/{name}")]
        public IActionResult AddTask([FromRoute]string name, [FromForm]TaskClass task)
        {
            homeService.AddTask(name, task);
            return RedirectToAction("home");
        }

        [HttpGet("delete/{name}/{id}")]
        public IActionResult DeleteStudentsTask([FromRoute]string name, [FromRoute]long id)
        {
            homeService.DeleteStudentsTask(name, id);
            return RedirectToAction("home");
        }

        [HttpPost("update/{name}")]
        public IActionResult UpdateTask([FromRoute]string name, [FromForm]TaskClass task)
        {
            homeService.UpdateTask(name, task);
            return RedirectToAction("home");
        }
    }
}
