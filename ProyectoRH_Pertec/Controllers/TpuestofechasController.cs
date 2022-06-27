using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProyectoRH_Pertec.Models;

namespace ProyectoRH_Pertec.Controllers
{
    public class TpuestofechasController : Controller
    {
        private RHEntities db = new RHEntities();

        public ActionResult Index()
        {
            var tpuestofechas = db.Tpuestofechas.Include(t => t.Templeado);
            return View(tpuestofechas.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tpuestofecha tpuestofecha = db.Tpuestofechas.Find(id);
            if (tpuestofecha == null)
            {
                return HttpNotFound();
            }
            return View(tpuestofecha);
        }

        public ActionResult Create()
        {
            ViewBag.PEempleadoID = new SelectList(db.Templeadoes, "EempleadoID", "Enombre");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PEfechaXempresaID,PEempleadoID,PEpuestoID,PEfechainicio,PEfechafin")] Tpuestofecha tpuestofecha)
        {
            if (ModelState.IsValid)
            {
                db.Tpuestofechas.Add(tpuestofecha);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PEempleadoID = new SelectList(db.Templeadoes, "EempleadoID", "Enombre", tpuestofecha.PEempleadoID);
            return View(tpuestofecha);
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tpuestofecha tpuestofecha = db.Tpuestofechas.Find(id);
            if (tpuestofecha == null)
            {
                return HttpNotFound();
            }
            ViewBag.PEempleadoID = new SelectList(db.Templeadoes, "EempleadoID", "Enombre", tpuestofecha.PEempleadoID);
            return View(tpuestofecha);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PEfechaXempresaID,PEempleadoID,PEpuestoID,PEfechainicio,PEfechafin")] Tpuestofecha tpuestofecha)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tpuestofecha).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PEempleadoID = new SelectList(db.Templeadoes, "EempleadoID", "Enombre", tpuestofecha.PEempleadoID);
            return View(tpuestofecha);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tpuestofecha tpuestofecha = db.Tpuestofechas.Find(id);
            if (tpuestofecha == null)
            {
                return HttpNotFound();
            }
            return View(tpuestofecha);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tpuestofecha tpuestofecha = db.Tpuestofechas.Find(id);
            db.Tpuestofechas.Remove(tpuestofecha);
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
