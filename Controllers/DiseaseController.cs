using Microsoft.AspNetCore.Mvc;

namespace HealthERP.Controllers
{
    public class DiseaseController : Controller
    {
        private readonly IConfiguration _configuration;

        public DiseaseController(IConfiguration configuration)
        {
            //_logger = logger;
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            ViewBag.ApiBaseUrl = _configuration.GetValue<string>("ApiSettings:BaseUrl");

            return View();
        }
    }
}
