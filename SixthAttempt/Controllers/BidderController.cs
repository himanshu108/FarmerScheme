using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SixthAttempt.Controllers
{
    public class BidderController : Controller
    {
        // GET: Bidder
        public ActionResult BidderProfile()
        {
            return View();
        }

        public ActionResult Market()
        {
            return View();
        }

        public ActionResult purchaseHistory()
        {
            return View();
        }
    }
}