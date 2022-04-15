using SixthAttempt.Models;
using SixthAttempt.Models.DBFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SixthAttempt.Controllers
{
    public class HomeController : Controller
    {
       public ActionResult LogIn()
        {
            return View();
        }

        public ActionResult AdminLogIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminLogIn(Admin admin)
        {
            using (var context = new DBFiles())
            {
                bool isValid = context.admins.Any(x => x.userName == admin.userName && x.password == admin.password);
                if (isValid)
                {
                    return RedirectToAction("AdminProfile", "Admin");
                }
                ModelState.AddModelError("", "Invalid Credintials");
            }
            return View();
        }

        public ActionResult FarmerLogIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FarmerLogIn(Farmer farmer)
        {
            using (var context = new DBFiles())
            {
                bool isValid = context.farmers.Any(y => y.userName == farmer.userName && y.password == farmer.password);
                if (isValid)
                {
                    return RedirectToAction("FarmerProfile", "Farmer");
                }
                ModelState.AddModelError("", "Invalid Credintials");
            }
            return View();
        }

        public ActionResult BidderLogIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BidderLogIn(Bidder bidder)
        {
            using (var context = new DBFiles())
            {
                bool isValid = context.bidders.Any(z => z.userName == bidder.userName && z.password == bidder.password);
                if (isValid)
                {
                    return RedirectToAction("BidderProfile", "Bidder");
                }
                ModelState.AddModelError("", "Invalid Credintials");
            }
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}