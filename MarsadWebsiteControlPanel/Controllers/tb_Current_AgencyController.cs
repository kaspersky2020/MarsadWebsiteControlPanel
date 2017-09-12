using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MarsadWebsiteControlPanel.Models;

namespace MarsadWebsiteControlPanel.Controllers
{
    public class tb_Current_AgencyController : Controller
    {
        private MarsadWebsiteControlPanelEntities db = new MarsadWebsiteControlPanelEntities();

        // GET: tb_Current_Agency
        public ActionResult Index()
        {
            var tb_Current_Agency = db.tb_Current_Agency.Include(t => t.tb_Current_Consumer).Include(t => t.tb_Current_Provider);
            return View(tb_Current_Agency.ToList());
        }

        // GET: tb_Current_Agency/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Current_Agency tb_Current_Agency = db.tb_Current_Agency.Find(id);
            if (tb_Current_Agency == null)
            {
                return HttpNotFound();
            }
            return View(tb_Current_Agency);
        }

        // GET: tb_Current_Agency/Create
        public ActionResult Create()
        {
            ViewBag.AgencyID = new SelectList(db.tb_Current_Consumer, "ConsumerID", "ConsumerArabicName");
            ViewBag.AgencyID = new SelectList(db.tb_Current_Provider, "ProviderID", "ProviderArabicName");
            return View();
        }

        // POST: tb_Current_Agency/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AgencyID,AgencyArabicName,AgencyEnglishName,AgencyEnglishNameAbbreviation,AgencyCategoryID")] tb_Current_Agency tb_Current_Agency)
        {
            if (ModelState.IsValid)
            {
                db.tb_Current_Agency.Add(tb_Current_Agency);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AgencyID = new SelectList(db.tb_Current_Consumer, "ConsumerID", "ConsumerArabicName", tb_Current_Agency.AgencyID);
            ViewBag.AgencyID = new SelectList(db.tb_Current_Provider, "ProviderID", "ProviderArabicName", tb_Current_Agency.AgencyID);
            return View(tb_Current_Agency);
        }

        // GET: tb_Current_Agency/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Current_Agency tb_Current_Agency = db.tb_Current_Agency.Find(id);
            if (tb_Current_Agency == null)
            {
                return HttpNotFound();
            }
            ViewBag.AgencyID = new SelectList(db.tb_Current_Consumer, "ConsumerID", "ConsumerArabicName", tb_Current_Agency.AgencyID);
            ViewBag.AgencyID = new SelectList(db.tb_Current_Provider, "ProviderID", "ProviderArabicName", tb_Current_Agency.AgencyID);
            return View(tb_Current_Agency);
        }

        // POST: tb_Current_Agency/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AgencyID,AgencyArabicName,AgencyEnglishName,AgencyEnglishNameAbbreviation,AgencyCategoryID")] tb_Current_Agency tb_Current_Agency)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_Current_Agency).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AgencyID = new SelectList(db.tb_Current_Consumer, "ConsumerID", "ConsumerArabicName", tb_Current_Agency.AgencyID);
            ViewBag.AgencyID = new SelectList(db.tb_Current_Provider, "ProviderID", "ProviderArabicName", tb_Current_Agency.AgencyID);
            return View(tb_Current_Agency);
        }

        // GET: tb_Current_Agency/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Current_Agency tb_Current_Agency = db.tb_Current_Agency.Find(id);
            if (tb_Current_Agency == null)
            {
                return HttpNotFound();
            }
            return View(tb_Current_Agency);
        }

        // POST: tb_Current_Agency/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            tb_Current_Agency tb_Current_Agency = db.tb_Current_Agency.Find(id);
            db.tb_Current_Agency.Remove(tb_Current_Agency);
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
