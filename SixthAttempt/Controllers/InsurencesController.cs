using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SixthAttempt.Models;
using SixthAttempt.Models.DBFiles;

namespace SixthAttempt.Controllers
{
    public class InsurencesController : Controller
    {
        private DBFiles db = new DBFiles();

        // GET: Insurences
        public ActionResult Index()
        {
            return View(db.insurences.ToList());
        }

        // GET: Insurences/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurence insurence = db.insurences.Find(id);
            if (insurence == null)
            {
                return HttpNotFound();
            }
            return View(insurence);
        }

        // GET: Insurences/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insurences/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "companyID,companyName,city,ownerOfCompany")] Insurence insurence)
        {
            if (ModelState.IsValid)
            {
                db.insurences.Add(insurence);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insurence);
        }

        // GET: Insurences/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurence insurence = db.insurences.Find(id);
            if (insurence == null)
            {
                return HttpNotFound();
            }
            return View(insurence);
        }

        // POST: Insurences/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "companyID,companyName,city,ownerOfCompany")] Insurence insurence)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insurence).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insurence);
        }

        // GET: Insurences/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurence insurence = db.insurences.Find(id);
            if (insurence == null)
            {
                return HttpNotFound();
            }
            return View(insurence);
        }

        // POST: Insurences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insurence insurence = db.insurences.Find(id);
            db.insurences.Remove(insurence);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
