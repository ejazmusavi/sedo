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
        [Route("")]
        [Route("{culture}")]
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

        [Route("{culture}/buy-domains/how-it-works/")]
        public IActionResult Working()
        {
            return View();
        }
        [Route("{culture}/buy-domains/domain-search/")]
        public IActionResult Search()
        {
            return View();
        }
        [Route("{culture}/buy-domains/domain-acquisition/")]
        public IActionResult Acquisition()
        {
            return View();
        }
        [Route("{culture}/buy-domains/auction-calendar/")]
        public IActionResult AuctionCalendar()
        {
            return View();
        }
      [Route("{culture}/buy-domains/market-trends/")]
        public IActionResult MarketTrends()
        {
            return View();
        }
        [Route("{culture}/sell-domains/how-it-works/")]
        public IActionResult WorkingDomain ()
        {
            return View();
        }
        [Route("{culture}/sell-domains/domain-trade/")]
        public IActionResult Trade()
        {
            return View();
        }
        [Route("{culture}/sell-domains/domain-Auction/")]
        public IActionResult DomainAuction()
        {
            return View();
        }
        [Route("{culture}/sell-domains/promotion-options/")]
        public IActionResult Promotion()
        {
            return View();
        }
        [Route("{culture}/park-domains/parking-domains/")]
        public IActionResult DomainParking()
        {
            return View();
        }
        [Route("{culture}/services/service-overview/")]
        public IActionResult Services()
        {
            return View();
        }
        [Route("{culture}/services/domain-appraisal/")]
        public IActionResult Appraisals()
        {
            return View();
        }
        [Route("{culture}/services/broker-service/")]
        public IActionResult BrokerService()
        {
            return View();
        }
        [Route("{culture}/services/domain-transfer-service/")]
        public IActionResult Transferring()
        {
            return View();
        }
        [Route("{culture}/services/sedos-partner-program/")]
        public IActionResult PartnerProgram()
        {
            return View();
        }
       
        
        [Route("{culture}/know-how-support/customer-support/")]
        public IActionResult Support()
        {
            return View();
        }
        [Route("{culture}/know-how-support/domain-law/")]
        public IActionResult Law()
        {
            return View();
        }

        [Route("{culture}/search/")]
        public IActionResult Com()
        {
            return View();
        }
        [Route("{culture}/about/sedo-the-company/")]
        public IActionResult SedoCompany()
        {
            return View();
        }
        [Route("{culture}/about/news-press/")]
        public IActionResult News()
        {
            return View();
        }
        [Route("{culture}/about/events/")]
        public IActionResult Events()
        {
            return View();
        }
        [Route("{culture}/about/case-studies/")]
        public IActionResult CaseStudies()
        {
            return View();
        }

        [Route("{culture}/about/careers/")]
        public IActionResult Careers()
        {
            return View();
        }
        [Route("{culture}/auth/")]
        public IActionResult Login()
        {
            return View();
        }
        [Route("{culture}/member/register.php/")]
        public IActionResult Register()
        {
            return View();
        }
        [Route("{culture}/about/imprint/")]
        public IActionResult CompanyInfo()
        {
            return View();
        }
        [Route("{culture}/about/policies/protecting-your-privacy/")]
        public IActionResult ProtectingPrivacy()
        {
            return View();
        }
        //[Route("{culture}/")]
        //public IActionResult CookieSettings()
        //{
        //    return View();
        //}
        [Route("{culture}/about/policies/")]
        public IActionResult Policies()
        {
            return View();
        }
        [Route("{culture}/brokerage/acquisition/")]
        public IActionResult OurServices()
        {
            return View();
        }
        //[Route("{culture}/sedo/")]
        //public IActionResult Twitter()
        //{
        //    return View();
        //}
        //[Route("{culture}/about-us/")]
        //public IActionResult Facebook()
        //{
        //    return View();
        //}
        //[Route("{culture}/sedodomains/")]
        //public IActionResult Insta()
        //{
        //    return View();
        //}
        //[Route("{culture}/user/SedoLLC/")]
        //public IActionResult Youtube()
        //{
        //    return View();
        //}
        //[Route("{culture}/know-how-support/")]
        //public IActionResult KnowHowSupport()
        //{
        //    return View();
        //}
        [Route("{culture}/about/")]
        public IActionResult About()
        {
            return View();
        }
        [Route("{culture}/us/about-us/news-press/newsroom/sedo-end-user-case-study-desktopcom/")]
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
