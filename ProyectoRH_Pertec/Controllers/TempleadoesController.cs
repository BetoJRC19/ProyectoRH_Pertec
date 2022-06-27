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
    public class TempleadoesController : Controller
    {
        private RHEntities db = new RHEntities();

        // GET: Templeadoes
        public ActionResult Index()
        {
            var templeadoes = db.Templeadoes.Include(t => t.Tpuesto).Include(t => t.Tempresafecha);
            return View(templeadoes.ToList());
        }

        // GET: Templeadoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Templeado templeado = db.Templeadoes.Find(id);
            if (templeado == null)
            {
                return HttpNotFound();
            }
            return View(templeado);
        }

        // GET: Templeadoes/Create
        public ActionResult Create()
        {
            ViewBag.EpuestoID = new SelectList(db.Tpuestoes, "PpuestoID", "Pnombre");
            ViewBag.EempleadoID = new SelectList(db.Tempresafechas, "IEempleadoID", "IEmotivo");
            return View();
        }

        // POST: Templeadoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EempleadoID,Enombre,Eapellido,Eapellido2,Etelefono,Ecorreo,EpuestoID")] Templeado templeado)
        {
            if (ModelState.IsValid)
            {
                db.Templeadoes.Add(templeado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EpuestoID = new SelectList(db.Tpuestoes, "PpuestoID", "Pnombre", templeado.EpuestoID);
            ViewBag.EempleadoID = new SelectList(db.Tempresafechas, "IEempleadoID", "IEmotivo", templeado.EempleadoID);
            return View(templeado);
        }

        // GET: Templeadoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Templeado templeado = db.Templeadoes.Find(id);
            if (templeado == null)
            {
                return HttpNotFound();
            }
            ViewBag.EpuestoID = new SelectList(db.Tpuestoes, "PpuestoID", "Pnombre", templeado.EpuestoID);
            ViewBag.EempleadoID = new SelectList(db.Tempresafechas, "IEempleadoID", "IEmotivo", templeado.EempleadoID);
            return View(templeado);
        }

        // POST: Templeadoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EempleadoID,Enombre,Eapellido,Eapellido2,Etelefono,Ecorreo,EpuestoID")] Templeado templeado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(templeado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EpuestoID = new SelectList(db.Tpuestoes, "PpuestoID", "Pnombre", templeado.EpuestoID);
            ViewBag.EempleadoID = new SelectList(db.Tempresafechas, "IEempleadoID", "IEmotivo", templeado.EempleadoID);
            return View(templeado);
        }

        // GET: Templeadoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Templeado templeado = db.Templeadoes.Find(id);
            if (templeado == null)
            {
                return HttpNotFound();
            }
            return View(templeado);
        }

        // POST: Templeadoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Templeado templeado = db.Templeadoes.Find(id);
            db.Templeadoes.Remove(templeado);
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
