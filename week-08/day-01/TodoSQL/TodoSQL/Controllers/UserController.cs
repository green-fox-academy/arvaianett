using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoSQL.Models;
using TodoSQL.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoSQL.Controllers
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
        [HttpGet("assignees")]
        public IActionResult Assignees()
        {
            return View(userRepository.GetView());
        }


    }
}
