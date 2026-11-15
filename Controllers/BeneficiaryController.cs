using Microsoft.AspNetCore.Mvc;

namespace HealthERP.Controllers
{
    public class BeneficiaryController : Controller
    {
        private readonly IConfiguration _configuration;
        private string ApiBaseUrl;
        private string HrAPIUrl;
        
        public BeneficiaryController(IConfiguration configuration)
        {
            //_logger = logger;
            _configuration = configuration;
            ApiBaseUrl = _configuration.GetValue<string>("ApiSettings:BaseUrl")??"";
            HrAPIUrl = _configuration.GetValue<string>("ApiSettings:HrAPIUrl")??"";
        }

        public IActionResult Index()
        {
            //ViewBag.ApiBaseUrl = _configuration.GetValue<string>("ApiSettings:BaseUrl");
            ViewBag.ApiBaseUrl = ApiBaseUrl;
            ViewBag.HrAPIUrl = HrAPIUrl;
           
            //ViewBag.Image = $"{HrAPIUrl}{id}/FamilyMembers/";

            return View();
        }

        public IActionResult NotGuarantee()
        {
            ViewBag.ApiBaseUrl = ApiBaseUrl;
            ViewBag.HrAPIUrl = HrAPIUrl;

            return View();
        }
    
        public IActionResult Profile(int id)
       {
            ViewBag.ApiBaseUrl = ApiBaseUrl;
            ViewBag.HrAPIUrl = HrAPIUrl;
            ViewBag.EmployeeId = id;
            ViewBag.Image = $"{HrAPIUrl}{id}/FamilyMembers/";

            return View();
        }

    }
}


