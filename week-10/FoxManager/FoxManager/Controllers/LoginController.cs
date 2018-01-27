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
    public class LoginController : Controller
    {
        private LoginService loginService;

        public LoginController(LoginService loginService)
        {
            this.loginService = loginService;
        }

        // GET: /<controller>/
        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("login")]
        public IActionResult Login([FromForm]string name, [FromForm]string password)
        {
            if(loginService.CheckInputs(name, password))
            {
                return Redirect($"home/{name}");
            }
            else
            {
                return Redirect("login");
            }
        }
    }
}
