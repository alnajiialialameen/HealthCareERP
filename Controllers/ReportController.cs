using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthERP.Controllers
{
  
    public class ReportController : Controller
    {
        private readonly IConfiguration _configuration;
        private string ApiBaseUrl;
        private string HrAPIUrl;

        public ReportController(IConfiguration configuration)
        {
            //_logger = logger;
            _configuration = configuration;
            ApiBaseUrl = _configuration.GetValue<string>("ApiSettings:BaseUrl") ?? "";
            HrAPIUrl = _configuration.GetValue<string>("ApiSettings:HrAPIUrl") ?? "";
        }

        public IActionResult MainReport()
        {
            //ViewBag.ApiBaseUrl = _configuration.GetValue<string>("ApiSettings:BaseUrl");
            ViewBag.ApiBaseUrl = ApiBaseUrl;
            ViewBag.HrAPIUrl = HrAPIUrl;

            //ViewBag.Image = $"{HrAPIUrl}{id}/FamilyMembers/";

            return View();
        }
        public IActionResult BeneficiaryWithFamilyReport()
        {
            //ViewBag.ApiBaseUrl = _configuration.GetValue<string>("ApiSettings:BaseUrl");
            ViewBag.ApiBaseUrl = ApiBaseUrl;
            ViewBag.HrAPIUrl = HrAPIUrl;

            //ViewBag.Image = $"{HrAPIUrl}{id}/FamilyMembers/";

            return View();
        }
        



        public IActionResult PrintMain(
        [FromQuery] int BeneficiaryType,
        [FromQuery] int? DepartmentId)
        {
            ViewBag.BeneficiaryType = BeneficiaryType;
            ViewBag.DepartmentId = DepartmentId;
            ViewBag.ApiBaseUrl = ApiBaseUrl;
            ViewBag.HrAPIUrl = HrAPIUrl;
            return View();
        }


        public IActionResult PrintBeneficiaryWithFamilyReport(
    [FromQuery] int BeneficiaryId)
        {
            ViewBag.BeneficiaryId = BeneficiaryId;
            //ViewBag.DepartmentId = DepartmentId;
            ViewBag.ApiBaseUrl = ApiBaseUrl;
            ViewBag.HrAPIUrl = HrAPIUrl;
            return View();
        }


        public IActionResult BeneficiaryAddressReport()
        {
            ViewBag.ApiBaseUrl = ApiBaseUrl;
            ViewBag.HrAPIUrl = HrAPIUrl;

            return View();
        }


        public IActionResult PrintBeneficiaryAddress([FromQuery] int? RegionId, [FromQuery] int? HousingId)
        {
            ViewBag.RegionId = RegionId;
            ViewBag.HousingId = HousingId;
            ViewBag.ApiBaseUrl = ApiBaseUrl;
            ViewBag.HrAPIUrl = HrAPIUrl;

            return View();
        }

        public IActionResult BeneficiaryDiseaseReport()
        {
            ViewBag.ApiBaseUrl = ApiBaseUrl;
            ViewBag.HrAPIUrl = HrAPIUrl;

            return View();
        }

        public IActionResult PrintBeneficiaryDisease([FromQuery] int? DiseaseId)
        {
            ViewBag.ApiBaseUrl = ApiBaseUrl;
            ViewBag.HrAPIUrl = HrAPIUrl;
            ViewBag.DiseaseId = DiseaseId;
            //ViewBag.HousingId = HousingId;
            return View();
        }


    }
}
