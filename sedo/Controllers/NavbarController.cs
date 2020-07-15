using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace sedo.Controllers
{
    public class NavbarController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        [Route("{culture}/what-we-offer/")]
        public IActionResult WhatWeOffer()
        {
            return View();
        }
        [Route("{culture}/buy-domains/")]
        public IActionResult BuyDomains()
        {
            return View();
        }
        [Route("{culture}/sell-domains/")]
        public IActionResult SellDomains()
        {
            return View();
        }
        [Route("{culture}/Park-domains/")]
        public IActionResult ParkDomains()
        {
            return View();
        }
        [Route("{culture}/services/")]
        public IActionResult OurServices()
        {
            return View();
        }
    }
}
