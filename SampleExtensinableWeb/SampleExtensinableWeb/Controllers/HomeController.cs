using Microsoft.AspNetCore.Mvc;
using SampleExtensinableWeb.Models;
using SampleExtensinableWeb.Services;
using System.Diagnostics;

namespace SampleExtensinableWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ModuleService ms;

        public HomeController(ILogger<HomeController> logger,ModuleService _ms)
        {
            _logger = logger;
            ms = _ms;
        }

        public IActionResult Index()
        {
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


        public IActionResult SamplePage() {

           
            ViewBag.Modules=ms.GetModules();


            return View();
        }


    }
}
