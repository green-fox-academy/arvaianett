using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace Frontend.Controllers
{
    [Route("api")]
    public class HomeController : Controller
    {
        // GET api/values
        [Route("")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet("/doubling")]
        public IActionResult Index(int? input)
        {
            if (input == null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            else
            {
                return Json(new { received = input, result = input * 2 });
            }
        }

        [HttpGet("/greeter")]
        public IActionResult Greeter([FromQuery]string name, [FromQuery]string title)
        {
            if(string.IsNullOrEmpty(name))
            {
                return Json(new { error = "Please provide a name!" });
            }
            else if(string.IsNullOrEmpty(title))
            {
                return Json(new { error = "Please provide a title!" });
            }
            else
            {
                return Json(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });
            }
        }

        [HttpGet("/appenda/{appendable}")]
        public IActionResult AppendA(string appendable)
        {
            return Json(new { appended = appendable + "a"});
        }

        [HttpGet("/appenda")]
        public IActionResult AppendAWithoutAppendable()
        {
            return NotFound();
        }
    }
}
