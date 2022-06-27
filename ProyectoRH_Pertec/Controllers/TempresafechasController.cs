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
    public class TempresafechasController : Controller
    {
        private RHEntities db = new RHEntities();

        // GET: Tempresafechas
        public ActionResult Index()
        {
            var tempresafechas = db.Tempresafechas.Include(t => t.Templeado);
            return View(tempresafechas.ToList());
        }

        // GET: Tempresafechas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tempresafecha tempresafecha = db.Tempresafechas.Find(id);
            if (tempresafecha == null)
            {
                return HttpNotFound();
            }
            return View(tempresafecha);
        }

        // GET: Tempresafechas/Create
        public ActionResult Create()
        {
            ViewBag.IEempleadoID = new SelectList(db.Templeadoes, "EempleadoID", "Enombre");
            return View();
        }

        // POST: Tempresafechas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IEfechaingreso,IEfechaegreso,IEmotivo,IEempleadoID")] Tempresafecha tempresafecha)
        {
            if (ModelState.IsValid)
            {
                db.Tempresafechas.Add(tempresafecha);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IEempleadoID = new SelectList(db.Templeadoes, "EempleadoID", "Enombre", tempresafecha.IEempleadoID);
            return View(tempresafecha);
        }

        // GET: Tempresafechas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tempresafecha tempresafecha = db.Tempresafechas.Find(id);
            if (tempresafecha == null)
            {
                return HttpNotFound();
            }
            ViewBag.IEempleadoID = new SelectList(db.Templeadoes, "EempleadoID", "Enombre", tempresafecha.IEempleadoID);
            return View(tempresafecha);
        }

        // POST: Tempresafechas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IEfechaingreso,IEfechaegreso,IEmotivo,IEempleadoID")] Tempresafecha tempresafecha)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tempresafecha).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IEempleadoID = new SelectList(db.Templeadoes, "EempleadoID", "Enombre", tempresafecha.IEempleadoID);
            return View(tempresafecha);
        }

        // GET: Tempresafechas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tempresafecha tempresafecha = db.Tempresafechas.Find(id);
            if (tempresafecha == null)
            {
                return HttpNotFound();
            }
            return View(tempresafecha);
        }

        // POST: Tempresafechas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tempresafecha tempresafecha = db.Tempresafechas.Find(id);
            db.Tempresafechas.Remove(tempresafecha);
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
