using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PallidaRetake.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PallidaRetake.Controllers
{
    [Route("")]
    public class WebShopController : Controller
    {
        private WebshopService webshopService;

        public WebShopController(WebshopService webshopService)
        {
            this.webshopService = webshopService;
        }

        // GET: /<controller>/
        [HttpGet("warehouse")]
        public IActionResult Webshop()
        {
            return View(webshopService.GetShopView());
        }

        [HttpPost("warehouse/summary")]
        public IActionResult Summary([FromForm]string itemName, [FromForm]string size, [FromForm]int quantity)
        {
            return View(webshopService.GetView(itemName, size, quantity));
        }

        [HttpGet("warehouse/query")]
        public IActionResult Query([FromQuery]double price, [FromQuery]string type)
        {
            return Json(new { result = "ok", clothes = webshopService.GetQuerySolution(price, type) });
        }
    }
}
