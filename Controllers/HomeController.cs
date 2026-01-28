using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HealthERP.Models;
using Microsoft.Extensions.Configuration;

namespace HealthERP.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IConfiguration _configuration;

    public HomeController(IConfiguration configuration)
    {
        //_logger = logger;
        _configuration = configuration;
    }

    public IActionResult Index()
    {
        ViewBag.ApiBaseUrl = _configuration.GetValue<string>("ApiSettings:BaseUrl");
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
