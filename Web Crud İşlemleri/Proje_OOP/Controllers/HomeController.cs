using Microsoft.AspNetCore.Mvc;
using Proje_OOP.Models;
using Proje_OOP.Ornekler;
using System.Diagnostics;

namespace Proje_OOP.Controllers
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


        public IActionResult Deneme()
        {

            Sehirler sehirler=new Sehirler();
            sehirler.Ad = "Kiev";
            sehirler.Id = 1;
            sehirler.Nüfus = 1000000;
            sehirler.Ulke = "Ukrayna";
            ViewBag.v1 = sehirler.Id;
            ViewBag.v2 = sehirler.Ad;
            ViewBag.v3 = sehirler.Nüfus;
            ViewBag.v4 = sehirler.Ulke;

            return View();
        }
    }
}