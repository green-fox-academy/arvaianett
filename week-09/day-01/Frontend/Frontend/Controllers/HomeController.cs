using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

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
            //try
            //{
            //    int doubled = input * 2;
            //    return Json(new { result = doubled });
            //}
            //catch (Exception)
            //{
            //    return Json(new { error = "Please provide an input!" });
            //}
        }
    }
}
