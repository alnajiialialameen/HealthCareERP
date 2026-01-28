using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace HealthERP.Controllers
{
    public class AuthController : Controller
    {
        private readonly IConfiguration _configuration;
        private string ApiBaseUrl;

        public AuthController(IConfiguration configuration)
        {
            //_logger = logger;
            _configuration = configuration;
            ApiBaseUrl = _configuration.GetValue<string>("ApiSettings:BaseUrl") ?? "";
        }
        public IActionResult Index()
        {
            ViewBag.ApiBaseUrl = ApiBaseUrl;

            return View();
        }

        public IActionResult Login()
        {
            ViewBag.ApiBaseUrl = ApiBaseUrl;
            return View();
        }

        public IActionResult Profile()
        {
            ViewBag.ApiBaseUrl = ApiBaseUrl;

            return View();
        }
    }
}
