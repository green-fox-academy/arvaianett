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
    public class LoginController : Controller
    {
        public Fox fox;
        public FoxViewModel foxViewModel;

        public LoginController(Fox fox, FoxViewModel foxViewModel)
        {
            this.fox = fox;
            this.foxViewModel = foxViewModel;
        }
        // GET: /<controller>/

        [HttpGet("")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("login")]
        public IActionResult LoginPost(string name)
        {
            fox.Name = name;
            foxViewModel.foxList.Add(new Fox() { Name = name });
            return Redirect("/index");
        }
    }
}
