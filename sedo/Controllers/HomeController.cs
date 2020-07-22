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

        [Route("/what-we-offer/what-sedo-offers/")]
        public IActionResult Offer()
        {
            return View();
        }

        [Route("/what-we-offer/registry-overview/")]
        public IActionResult Registry()
        {
            return View();
        }
        [Route("/what-we-offer/registrar-services/")]
        public IActionResult Registrar()
        {
            return View();
        }
        [Route("/what-we-offer/price-list/")]
        public IActionResult PriceList()
        {
            return View();
        }

        [Route("/buy-domains/how-it-works/")]
        public IActionResult Working()
        {
            return View();
        }
        [Route("/buy-domains/domain-search/")]
        public IActionResult Search()
        {
            return View();
        }
        [Route("/buy-domains/domain-acquisition/")]
        public IActionResult Acquisition()
        {
            return View();
        }
        [Route("/buy-domains/auction-calendar/")]
        public IActionResult AuctionCalendar()
        {
            return View();
        }
      [Route("/buy-domains/market-trends/")]
        public IActionResult MarketTrends()
        {
            return View();
        }
        [Route("/sell-domains/how-it-works/")]
        public IActionResult WorkingDomain ()
        {
            return View();
        }
        [Route("/sell-domains/domain-trade/")]
        public IActionResult Trade()
        {
            return View();
        }
        [Route("/sell-domains/domain-Auction/")]
        public IActionResult DomainAuction()
        {
            return View();
        }
        [Route("/sell-domains/promotion-options/")]
        public IActionResult Promotion()
        {
            return View();
        }
        [Route("/park-domains/parking-domains/")]
        public IActionResult DomainParking()
        {
            return View();
        }
        [Route("/services/service-overview/")]
        public IActionResult Services()
        {
            return View();
        }
        [Route("/services/domain-appraisal/")]
        public IActionResult Appraisals()
        {
            return View();
        }
        [Route("/services/broker-service/")]
        public IActionResult BrokerService()
        {
            return View();
        }
        [Route("/services/domain-transfer-service/")]
        public IActionResult Transferring()
        {
            return View();
        }
        [Route("/services/sedos-partner-program/")]
        public IActionResult PartnerProgram()
        {
            return View();
        }
       
        
        [Route("/know-how-support/customer-support/")]
        public IActionResult Support()
        {
            return View();
        }
        [Route("/know-how-support/domain-law/")]
        public IActionResult Law()
        {
            return View();
        }

        [Route("/search/")]
        public IActionResult Com()
        {
            return View();
        }
        [Route("/about/sedo-the-company/")]
        public IActionResult SedoCompany()
        {
            return View();
        }
        [Route("/about/news-press/")]
        public IActionResult News()
        {
            return View();
        }
        [Route("/about/events/")]
        public IActionResult Events()
        {
            return View();
        }
        [Route("/about/case-studies/")]
        public IActionResult CaseStudies()
        {
            return View();
        }

        [Route("/about/careers/")]
        public IActionResult Careers()
        {
            return View();
        }
        [Route("/auth/")]
        public IActionResult Login()
        {
            return View();
        }
        [Route("/member/register.php/")]
        public IActionResult Register()
        {
            return View();
        }
        [Route("/about/imprint/")]
        public IActionResult CompanyInfo()
        {
            return View();
        }
        [Route("/about/policies/protecting-your-privacy/")]
        public IActionResult ProtectingPrivacy()
        {
            return View();
        }
        //[Route("/")]
        //public IActionResult CookieSettings()
        //{
        //    return View();
        //}
        [Route("/about/policies/")]
        public IActionResult Policies()
        {
            return View();
        }
        [Route("/brokerage/acquisition/")]
        public IActionResult OurServices()
        {
            return View();
        }
        //[Route("/sedo/")]
        //public IActionResult Twitter()
        //{
        //    return View();
        //}
        //[Route("/about-us/")]
        //public IActionResult Facebook()
        //{
        //    return View();
        //}
        //[Route("/sedodomains/")]
        //public IActionResult Insta()
        //{
        //    return View();
        //}
        //[Route("/user/SedoLLC/")]
        //public IActionResult Youtube()
        //{
        //    return View();
        //}
        //[Route("/know-how-support/")]
        //public IActionResult KnowHowSupport()
        //{
        //    return View();
        //}
        [Route("/about/")]
        public IActionResult About()
        {
            return View();
        }
        [Route("/us/about-us/news-press/newsroom/sedo-end-user-case-study-desktopcom/")]
        public IActionResult ReadStory()
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
