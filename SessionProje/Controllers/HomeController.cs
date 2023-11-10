using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SessionProje.Extensions;
using SessionProje.Models;
using System.Diagnostics;

namespace SessionProje.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var session = HttpContext.Session.Get<LoginModel>("UserSession"); //burdan session uma erişiyoruz
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
}