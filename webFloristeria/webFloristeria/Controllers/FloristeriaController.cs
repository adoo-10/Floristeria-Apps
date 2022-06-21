using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using webFloristeria.Models;

namespace webFloristeria.Controllers
{
    public class FloristeriaController : Controller
    {
        private FloristeriaParcialEntities db = new FloristeriaParcialEntities();

        // GET: Floristeria
        public ActionResult Index()
        {
            return View(db.Flores.ToList());
        }

        // GET: Floristeria/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Flores flores = db.Flores.Find(id);
            if (flores == null)
            {
                return HttpNotFound();
            }
            return View(flores);
        }

        // GET: Floristeria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Floristeria/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idFlor,nombreFlor,cantidad,precio,estado")] Flores flores)
        {
            if (ModelState.IsValid)
            {
                db.Flores.Add(flores);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(flores);
        }

        // GET: Floristeria/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Flores flores = db.Flores.Find(id);
            if (flores == null)
            {
                return HttpNotFound();
            }
            return View(flores);
        }

        // POST: Floristeria/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idFlor,nombreFlor,cantidad,precio,estado")] Flores flores)
        {
            if (ModelState.IsValid)
            {
                db.Entry(flores).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(flores);
        }

        // GET: Floristeria/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Flores flores = db.Flores.Find(id);
            if (flores == null)
            {
                return HttpNotFound();
            }
            return View(flores);
        }

        // POST: Floristeria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Flores flores = db.Flores.Find(id);
            db.Flores.Remove(flores);
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
