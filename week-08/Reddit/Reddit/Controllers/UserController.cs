using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reddit.Repositories;
using Reddit.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Reddit.Controllers
{
    [Route("")]
    public class UserController : Controller
    {
        private UserRepository userRepository;

        public UserController(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        // GET: /<controller>/
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("name")]
        public IActionResult RedirectToPersonalPage(User user)
        {
            userRepository.UserStatus(user);
            return Redirect("home");
        }
    }
}
