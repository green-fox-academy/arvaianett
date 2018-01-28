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
    public class TeamController : Controller
    {
        private TeamService teamService;

        public TeamController(TeamService teamService)
        {
            this.teamService = teamService;
        }

        // GET: /<controller>/
        [HttpGet("teams/{name}")]
        public IActionResult Teams([FromRoute]string name)
        {
            return View(teamService.GetTeamView(name));
        }

        [HttpPost("addteam/{name}")]
        public IActionResult AddTeam([FromRoute]string name, [FromForm]Team team)
        {
            teamService.AddTeam(name, team);
            return RedirectToAction("teams");
        }

        [HttpGet("deleteteam/{name}/{id}")]
        public IActionResult DeleteTeam([FromRoute]string name, [FromRoute]long id)
        {
            teamService.DeleteTeam(name, id);
            return RedirectToAction("teams");
        }

        [HttpPost("updateteam/{name}")]
        public IActionResult UpdateTeam([FromRoute]string name, [FromForm]Team team)
        {
            teamService.UpdateTeam(name, team);
            return RedirectToAction("teams");
        }
    }
}
