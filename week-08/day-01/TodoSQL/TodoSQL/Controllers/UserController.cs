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

        [HttpPost("adduser")]
        public IActionResult AddUser(User user)
        {
            userRepository.AddUser(user);
            return RedirectToAction("assignees");
        }

        [HttpGet("{id}/deleteuser")]
        public IActionResult DeleteUser(long id)
        {
            userRepository.DeleteUser(id);
            return RedirectToAction("assignees");
        }

        [HttpGet("{id}/edituser")]
        public IActionResult EditUser(long id)
        {
            return View(userRepository.EditUserView(id));
        }

        [HttpPost("{id}/edituser/updateuser")]
        public IActionResult UpdateUser(User user, [FromRoute]long id)
        {
            userRepository.UpdateUser(user, id);
            return RedirectToAction("assignees");
        }

        [HttpGet("{name}/getassigneestodos")]
        public IActionResult AssigneeTodos([FromRoute]string name)
        {
            return View(userRepository.GetAssigneesTodoView(name));
        }
    }
}
