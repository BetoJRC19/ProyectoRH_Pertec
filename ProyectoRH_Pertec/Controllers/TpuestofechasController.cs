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

        // GET: Tpuestofechas
        public ActionResult Index()
        {
            var tpuestofechas = db.Tpuestofechas.Include(t => t.Templeado);
            return View(tpuestofechas.ToList());
        }

        // GET: Tpuestofechas/Details/5
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

        // GET: Tpuestofechas/Create
        public ActionResult Create()
        {
            ViewBag.PEempleadoID = new SelectList(db.Templeadoes, "EempleadoID", "Enombre");
            return View();
        }

        // POST: Tpuestofechas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
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

        // GET: Tpuestofechas/Edit/5
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

        // POST: Tpuestofechas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
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

        // GET: Tpuestofechas/Delete/5
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

        // POST: Tpuestofechas/Delete/5
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
