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
    public class ClassController : Controller
    {
        private ClassService classService;

        public ClassController(ClassService classService)
        {
            this.classService = classService;
        }

        // GET: /<controller>/
        [HttpGet("classes/{name}")]
        public IActionResult Class([FromRoute]string name)
        {
            return View(classService.GetClassView(name));
        }

        [HttpPost("addclass/{name}")]
        public IActionResult AddClass([FromRoute]string name, [FromForm]Class foxClass)
        {
            classService.AddClass(name, foxClass);
            return RedirectToAction("class");
        }

        [HttpGet("deleteclass/{name}/{id}")]
        public IActionResult DeleteClass([FromRoute]string name, [FromRoute]long id)
        {
            classService.DeleteClass(name, id);
            return RedirectToAction("class");
        }

        [HttpPost("updateclass/{name}")]
        public IActionResult UpdateClass([FromRoute]string name, [FromForm]Class foxClass)
        {
            classService.UpdateClass(name, foxClass);
            return RedirectToAction("class");
        }
    }
}
