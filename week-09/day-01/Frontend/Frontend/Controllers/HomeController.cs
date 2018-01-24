using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using Frontend.Models;

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

        [HttpGet("doubling")]
        public IActionResult Index([FromQuery]int? input)
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

        [HttpGet("greeter")]
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

        [HttpGet("appenda/{appendable}")]
        public IActionResult AppendA([FromRoute]string appendable)
        {
            return Json(new { appended = appendable + "a"});
        }

        [HttpGet("appenda")]
        public IActionResult AppendAWithoutAppendable()
        {
            return NotFound();
        }

        [HttpPost("dountil/{what}")]
        public IActionResult DoUntil(string what, [FromBody]DoUntil until)
        {
            int? input = until.Until;

            if (input == null)
            {
                return Json(new { error = "Please provide a number!" });
            }
            else if (what.Equals("sum"))
            {
                int number = 0;
                for (int i = 1; i <= input; i++)
                {
                    number += i;
                }
                return Json(new { until = input, result = number});
            }
            else if (what.Equals("factor"))
            {
                int number = 1;

                for (int i = 1; i <= input; i++)
                {
                    number *= i;
                }
                return Json(new { until = input, result = number });
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost("arrays")]
        public IActionResult ArrayHandler([FromBody]ArrayHandler array)
        {
            if(array.What.Equals("sum"))
            {
                int number = 0;

                return Json(new { result = number });
            }
            else if(array.What.Equals("multiply"))
            {
                int number = 1;
                
                return Json(new { result = number });
            }
            else if(array.What.Equals("double"))
            {
                int[] doubledArray = new int[] { 1,2,3,4,5,6,7};

                return Json(new { result = doubledArray });
            }
            else
            {
                return Json(new { error = "Please provide what to do with the numbers!" });
            }
        }
    }
}
