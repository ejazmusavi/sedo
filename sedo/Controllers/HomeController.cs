using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sedo.Models;

namespace sedo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("{culture}/what-we-offer/what-sedo-offers/")]
        public IActionResult Offer()
        {
            return View();
        }
        [Route("{culture}/what-we-offer/registry-overview/")]
        public IActionResult Registry()
        {
            return View();
        }
        [Route("{culture}/what-we-offer/registrar-services/")]
        public IActionResult Registrar()
        {
            return View();
        }
        [Route("{culture}/what-we-offer/price-list/")]
        public IActionResult PriceList()
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
    }
}
