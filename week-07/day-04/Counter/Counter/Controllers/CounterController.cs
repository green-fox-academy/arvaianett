using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Counter.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Counter.Controllers
{
    public class CounterController : Controller
    {
        public CounterModel counterView;

        public CounterController(CounterModel counterView)
        {
            this.counterView = counterView;
        }
        // GET: /<controller>/
        [HttpGet("")]
        public IActionResult Index()
        {
            return View(counterView);
        }

        [HttpPost("")]
        public IActionResult PostMethod()
        {
            return RedirectToAction("Index");
        }
    }
}
