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
    public class CropListsController : Controller
    {
        private DBFiles db = new DBFiles();

        // GET: CropLists
        public ActionResult Index()
        {
            return View(db.croplists.ToList());
        }

        // GET: CropLists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CropList cropList = db.croplists.Find(id);
            if (cropList == null)
            {
                return HttpNotFound();
            }
            return View(cropList);
        }

        // GET: CropLists/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CropLists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cropID,cropName,cropType,cropQuantity,basePrice,sellPrice")] CropList cropList)
        {
            if (ModelState.IsValid)
            {
                db.croplists.Add(cropList);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cropList);
        }

        // GET: CropLists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CropList cropList = db.croplists.Find(id);
            if (cropList == null)
            {
                return HttpNotFound();
            }
            return View(cropList);
        }

        // POST: CropLists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cropID,cropName,cropType,cropQuantity,basePrice,sellPrice")] CropList cropList)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cropList).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cropList);
        }

        // GET: CropLists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CropList cropList = db.croplists.Find(id);
            if (cropList == null)
            {
                return HttpNotFound();
            }
            return View(cropList);
        }

        // POST: CropLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CropList cropList = db.croplists.Find(id);
            db.croplists.Remove(cropList);
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
