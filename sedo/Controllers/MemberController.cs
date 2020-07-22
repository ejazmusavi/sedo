using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace sedo.Controllers
{
    public class MemberController : Controller
    {
        [Route("/brokerage/acquisition/")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("/member/index/")]
        public IActionResult MySedo()
        {
            return View();
        }
        [Route("/member/domainsignup/index")]
        public IActionResult AddDomain()
        {
            return View();
        }
        [Route("/member/dnmanagement/")]
        public IActionResult MyDomain()
        {
            return View();
        }
        [Route("/member/parking-tools/overview/")]
        public IActionResult ParkingReports()
        {
            return View();
        }
        [Route("/member/controlpanel/")]
        public IActionResult BuyerPanel()
        {
            return View();
        }
        [Route("/member/domainforsalewatch/")]
        public IActionResult KeywordsList()
        {
            return View();
        }
        [Route("/member/transfer/index/")]
        public IActionResult TransferCenter()
        {
            return View();
        }
        [Route("/member/billing/invoicelist/")]
        public IActionResult Billing()
        {
            return View();
        }
        [Route("/member/partner/index/")]
        public IActionResult PartnerProgram()
        {
            return View();
        }
        [Route("/member/editaccount/")]
        public IActionResult MyAccount()
        {
            return View();
        }
        [Route("/member/logout/")]
        public IActionResult Logout()
        {
            return View();
        }
       
    }
}


