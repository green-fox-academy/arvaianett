using Microsoft.AspNetCore.Mvc;
using PallidaExam.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PallidaExam.Controllers
{
    [Route("api")]
    public class ValuesController : Controller
    {
        private LicencePlateService licencePlateService;

        public ValuesController(LicencePlateService licencePlateService)
        {
            this.licencePlateService = licencePlateService;
        }

        // GET: api/values
        [HttpGet("search/{brand}")]
        public IActionResult Get([FromRoute]string brand)
        {
            return Json(new { result = "ok", data = licencePlateService.GetFilteredListByBrand(brand)});
        }
    }
}
