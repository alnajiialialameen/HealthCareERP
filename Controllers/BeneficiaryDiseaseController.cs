using Microsoft.AspNetCore.Mvc;

namespace HealthERP.Controllers
{
    public class BeneficiaryDiseaseController : Controller
    {
        private readonly IConfiguration _configuration;

        public BeneficiaryDiseaseController(IConfiguration configuration)
        {
            //_logger = logger;
            _configuration = configuration;
        }
        public IActionResult BeneficiaryDisease(int id)
        {
            ViewBag.ApiBaseUrl = _configuration.GetValue<string>("ApiSettings:BaseUrl");
            ViewBag.BeneficiaryId = id;


            return View();
        }
    }
}
