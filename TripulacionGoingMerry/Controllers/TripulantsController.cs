using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TripulacionGoingMerry.DAL;
using TripulacionGoingMerry.Models;

namespace TripulacionGoingMerry.Controllers
{
    public class TripulantsController : Controller
    {
        private TripContext db = new TripContext();

        // GET: Tripulants
        public ActionResult Index()
        {
            return View(db.Tripulants.ToList());
        }

        // GET: Tripulants/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tripulant tripulant = db.Tripulants.Find(id);
            if (tripulant == null)
            {
                return HttpNotFound();
            }
            return View(tripulant);
        }

        // GET: Tripulants/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tripulants/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,EnrollmentDate")] Tripulant tripulant)
        {
            if (ModelState.IsValid)
            {
                db.Tripulants.Add(tripulant);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tripulant);
        }

        // GET: Tripulants/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tripulant tripulant = db.Tripulants.Find(id);
            if (tripulant == null)
            {
                return HttpNotFound();
            }
            return View(tripulant);
        }

        // POST: Tripulants/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,EnrollmentDate")] Tripulant tripulant)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tripulant).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tripulant);
        }

        // GET: Tripulants/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tripulant tripulant = db.Tripulants.Find(id);
            if (tripulant == null)
            {
                return HttpNotFound();
            }
            return View(tripulant);
        }

        // POST: Tripulants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tripulant tripulant = db.Tripulants.Find(id);
            db.Tripulants.Remove(tripulant);
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
