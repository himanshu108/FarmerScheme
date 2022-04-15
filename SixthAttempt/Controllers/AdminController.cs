using SixthAttempt.Models;
using SixthAttempt.Models.DBFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SixthAttempt.Controllers
{
    public class AdminController : Controller
    {
        DBFiles db= new DBFiles();
        // GET: Admin
        public ActionResult AdminProfile()
        {
            return View();
        }
       
        [HttpGet]
         public ActionResult ViewFarmers()
        {
            return View(db.farmers.ToList());
        }


        [HttpGet]
        public ActionResult ViewBidders()
        {
            return View(db.bidders.ToList());
        }

        [HttpGet]
        public ActionResult viewAplliedInsurence()
        {
            return View(db.insurences.ToList());
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admin admin = db.admins.Find(id);
            if (admin == null)
            {
                return HttpNotFound();
            }
            return View(admin);
        }

        // GET: Admins/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admin admin = db.admins.Find(id);
            if (admin == null)
            {
                return HttpNotFound();
            }
            return View(admin);
        }

        // POST: Admins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Admin admin = db.admins.Find(id);
            db.admins.Remove(admin);
            db.SaveChanges();
            return View(db.farmers.ToList());
        }

    }

}