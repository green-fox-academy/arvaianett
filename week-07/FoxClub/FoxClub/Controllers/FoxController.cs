using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoxClub.Models;
using FoxClub.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoxClub.Controllers
{
    [Route("")]
    public class FoxController : Controller
    {
        public Fox fox;
        public FoxViewModel foxViewModel;

        public FoxController(Fox fox, FoxViewModel foxViewModel)
        {
            this.fox = fox;
            this.foxViewModel = foxViewModel;
        }
        // GET: /<controller>/
        [HttpGet("nutrition")]
        public IActionResult Index()
        {
            return View(fox);
        }

        [HttpPost("changenutrition")]
        public IActionResult Nutrition(string food, string drink)
        {
            fox.Food = food;
            fox.Drink = drink;

            return Redirect("/index");
        }

        [HttpGet("tricks")]
        public IActionResult Tricks()
        {
            return View(fox);
        }

        [HttpPost("addtrick")]
        public IActionResult AddTricks(string trick)
        {
            fox.ListOfTricks.Add(trick);

            return Redirect("/index");
        }
    }
}
