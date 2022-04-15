using SixthAttempt.Models;
using SixthAttempt.Models.DBFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SixthAttempt.Controllers
{
    public class FarmerController : Controller
    {
        DBFiles db = new DBFiles();
        // GET: Farmer
        public ActionResult FarmerProfile()
        {
            return View();
        }


        public ActionResult AddCrops()
        {
            return View();
        }

      
        // POST: CropLists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddCrops([Bind(Include = "cropID,cropName,cropType,cropQuantity,basePrice,sellPrice")] CropList cropList)
        {
            if (ModelState.IsValid)
            {
                db.croplists.Add(cropList);
                db.SaveChanges();
                return RedirectToAction("showCrops");
            }

            return View(cropList);
        }

        [HttpGet]
        public ActionResult showCrops()
        {
            return View(db.croplists.ToList());
        }

        public ActionResult ApplyForInsurence()
        {
            return View();
        }

    }
}