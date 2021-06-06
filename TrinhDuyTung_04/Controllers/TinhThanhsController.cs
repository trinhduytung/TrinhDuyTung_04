using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TrinhDuyTung_04.Models;

namespace TrinhDuyTung_04.Controllers
{
    public class TinhThanhsController : Controller
    {
        private LTQLDb db = new LTQLDb();

        // GET: TinhThanhs
        public ActionResult Index()
        {
            return View(db.MaTinhThanhs.ToList());
        }

        // GET: TinhThanhs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TinhThanh tinhThanh = db.MaTinhThanhs.Find(id);
            if (tinhThanh == null)
            {
                return HttpNotFound();
            }
            return View(tinhThanh);
        }

        // GET: TinhThanhs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TinhThanhs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaTinhThanh,TenTinhThanh")] TinhThanh tinhThanh)
        {
            if (ModelState.IsValid)
            {
                db.MaTinhThanhs.Add(tinhThanh);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tinhThanh);
        }

        // GET: TinhThanhs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TinhThanh tinhThanh = db.MaTinhThanhs.Find(id);
            if (tinhThanh == null)
            {
                return HttpNotFound();
            }
            return View(tinhThanh);
        }

        // POST: TinhThanhs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaTinhThanh,TenTinhThanh")] TinhThanh tinhThanh)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tinhThanh).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tinhThanh);
        }

        // GET: TinhThanhs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TinhThanh tinhThanh = db.MaTinhThanhs.Find(id);
            if (tinhThanh == null)
            {
                return HttpNotFound();
            }
            return View(tinhThanh);
        }

        // POST: TinhThanhs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TinhThanh tinhThanh = db.MaTinhThanhs.Find(id);
            db.MaTinhThanhs.Remove(tinhThanh);
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
