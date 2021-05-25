using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using assignment_2_task_6.Models;

namespace assignment_2_task_6.Controllers
{
    public class MenuModelsController : Controller
    {
        private MenuDBContext db = new MenuDBContext();

        // GET: MenuModels
        public ActionResult Index()
        {
            return View(db.MenuModels.ToList());
        }

        // GET: MenuModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuModel menuModel = db.MenuModels.Find(id);
            if (menuModel == null)
            {
                return HttpNotFound();
            }
            return View(menuModel);
        }

        // GET: MenuModels/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: MenuModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create([Bind(Include = "Id,itemName,itemPrice,itemDescription")] MenuModel menuModel)
        {
            if (ModelState.IsValid)
            {
                db.MenuModels.Add(menuModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(menuModel);
        }

        // GET: MenuModels/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuModel menuModel = db.MenuModels.Find(id);
            if (menuModel == null)
            {
                return HttpNotFound();
            }
            return View(menuModel);
        }

        // POST: MenuModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit([Bind(Include = "Id,itemName,itemPrice,itemDescription")] MenuModel menuModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(menuModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(menuModel);
        }

        // GET: MenuModels/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuModel menuModel = db.MenuModels.Find(id);
            if (menuModel == null)
            {
                return HttpNotFound();
            }
            return View(menuModel);
        }

        // POST: MenuModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult DeleteConfirmed(int id)
        {
            MenuModel menuModel = db.MenuModels.Find(id);
            db.MenuModels.Remove(menuModel);
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
