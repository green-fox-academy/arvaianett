using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Anagram.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Anagram.Controllers
{
    [Route("")]
    public class AnagramController : Controller
    {
        public AnagramModel anagramModel;

        public AnagramController(AnagramModel anagramModel)
        {
            this.anagramModel = anagramModel;
        }

        // GET: /<controller>/
        [HttpGet("")]
        public IActionResult Index()
        {
            return View(anagramModel);
        }

        [HttpPost("add")]
        public IActionResult PostMethod(string firstWord, string secondWord)
        {
            anagramModel.FirstWord = firstWord;
            anagramModel.SecondWord = secondWord;

            return RedirectToAction("result");
        }

        [HttpGet("result")]
        public IActionResult Result()
        {
            return View(anagramModel);
        }
    }
}
