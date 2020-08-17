using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;
using CarInsurance.ViewModels;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: Insuree/Admin
        public ActionResult Admin()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {

                
                var insurees = db.Insurees;
                var quoteVMs = new List<QuoteVM>();
                foreach (var insuree in insurees)
                {
                    var quoteVM = new QuoteVM();
                    quoteVM.FirstName = insuree.FirstName;
                    quoteVM.LastName = insuree.LastName;
                    quoteVM.EmailAddress = insuree.EmailAddress;
                    quoteVM.Quote = insuree.Quote;
                    quoteVMs.Add(quoteVM);
                }
                return View(quoteVMs);
            }
            
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                // Quote Calculations
                insuree.Quote = 50;
                var today = DateTime.Today;
                var age = today.Year - insuree.DateOfBirth.Year;

                if (age <= 18)
                {
                    insuree.Quote += 100;
                }
                else if (age > 25)
                {
                    insuree.Quote += 25;
                }
                else
                {
                    insuree.Quote += 50;
                }
                if (insuree.CarYear < 2000)
                {
                    insuree.Quote += 25;
                }
                else if (insuree.CarYear > 2015)
                {
                    insuree.Quote += 25;
                }
                if (insuree.CarMake == "Porshe")
                {
                    insuree.Quote += 25;
                    if (insuree.CarModel == "911 Carrera")
                    {
                        insuree.Quote += 25;
                    }
                }
                if (insuree.SpeedingTickets >= 1)
                {
                    var ticketsPenalty = insuree.SpeedingTickets * 10;
                    insuree.Quote += ticketsPenalty;
                }
                if (insuree.DUI)
                {
                    var duiPenalty = insuree.Quote * .25m;
                    insuree.Quote += duiPenalty;
                }
                if (insuree.CoverageType)
                {
                    var fullCoverage = insuree.Quote * .50m;
                    insuree.Quote += fullCoverage;
                }
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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
