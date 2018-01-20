using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reddit2.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Reddit2.Controllers
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
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("login")]
        public IActionResult RedirectToPersonalPage(string username)
        {
            if (loginService.UserStatus(username))
            {
                return Redirect($"posts/{username}");
            }
            else
            {
                loginService.AddUser(username);
                return Redirect($"posts/{username}");
            }
        }
    }
}
