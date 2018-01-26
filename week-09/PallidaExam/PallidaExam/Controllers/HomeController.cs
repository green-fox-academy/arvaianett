using Microsoft.AspNetCore.Mvc;
using PallidaExam.Services;
using PallidaExam.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PallidaExam.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private LicencePlateService licencePlateService;

        public HomeController(LicencePlateService licencePlateService)
        {
            this.licencePlateService = licencePlateService;
        }

        [HttpGet("search")]
        public IActionResult Search([FromQuery]FilterOptions filterOptions)
        {
            return View(licencePlateService.GetAllPlates(filterOptions));
        }

        [HttpGet("search/{brand}")]
        public IActionResult Search([FromRoute]string brand)
        {
            return View("search", licencePlateService.GetFilteredListByBrand(brand));
        }
    }
}
