using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace sedo.Controllers
{
    public class MemberController : Controller
    {
        [Route("{culture}/brokerage/acquisition/")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("{culture}/member/index/")]
        public IActionResult MySedo()
        {
            return View();
        }
        [Route("{culture}/member/domainsignup/index")]
        public IActionResult AddDomain()
        {
            return View();
        }
        [Route("{culture}/member/dnmanagement/")]
        public IActionResult MyDomain()
        {
            return View();
        }
        [Route("{culture}/member/parking-tools/overview/")]
        public IActionResult ParkingReports()
        {
            return View();
        }
        [Route("{culture}/member/controlpanel/")]
        public IActionResult BuyerPanel()
        {
            return View();
        }
        [Route("{culture}/member/domainforsalewatch/")]
        public IActionResult KeywordsList()
        {
            return View();
        }
        [Route("{culture}/member/transfer/index/")]
        public IActionResult TransferCenter()
        {
            return View();
        }
        [Route("{culture}/member/billing/invoicelist/")]
        public IActionResult Billing()
        {
            return View();
        }
        [Route("{culture}/member/partner/index/")]
        public IActionResult PartnerProgram()
        {
            return View();
        }
        [Route("{culture}/member/editaccount/")]
        public IActionResult MyAccount()
        {
            return View();
        }
        [Route("{culture}/member/logout/")]
        public IActionResult Logout()
        {
            return View();
        }
    }
}


