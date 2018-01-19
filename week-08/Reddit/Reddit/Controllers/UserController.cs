using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reddit.Repositories;
using Reddit.Models;
using Reddit.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Reddit.Controllers
{
    [Route("")]
    public class UserController : Controller
    {
        private UserServices userServices;

        public UserController(UserServices userServices)
        {
            this.userServices = userServices;
        }

        // GET: /<controller>/
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("username")]
        public IActionResult RedirectToPersonalPage(string username)
        {
            if (userServices.UserStatus(username))
            {
                return Redirect($"home/{username}");
            }
            else
            {
                userServices.AddUser(username);
                return Redirect($"home/{username}");
            }
        }
    }
}
