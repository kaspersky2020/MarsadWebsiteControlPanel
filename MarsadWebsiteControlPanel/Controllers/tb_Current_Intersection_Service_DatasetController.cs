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
    public class tb_Current_Intersection_Service_DatasetController : Controller
    {
        private MarsadWebsiteControlPanelEntities db = new MarsadWebsiteControlPanelEntities();

        // GET: tb_Current_Intersection_Service_Dataset
        public ActionResult Index()
        {
            var tb_Current_Intersection_Service_Dataset = db.tb_Current_Intersection_Service_Dataset.Include(t => t.tb_Current_MarsadDataset).Include(t => t.tb_Current_Service);
            return View(tb_Current_Intersection_Service_Dataset.ToList());
        }

        // GET: tb_Current_Intersection_Service_Dataset/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Current_Intersection_Service_Dataset tb_Current_Intersection_Service_Dataset = db.tb_Current_Intersection_Service_Dataset.Find(id);
            if (tb_Current_Intersection_Service_Dataset == null)
            {
                return HttpNotFound();
            }
            return View(tb_Current_Intersection_Service_Dataset);
        }

        // GET: tb_Current_Intersection_Service_Dataset/Create
        public ActionResult Create()
        {
            ViewBag.DatasetID = new SelectList(db.tb_Current_MarsadDataset, "DatasetID", "DatasetFullName");
            ViewBag.ServiceID = new SelectList(db.tb_Current_Service, "ServiceID", "ConsumerID");
            return View();
        }

        // POST: tb_Current_Intersection_Service_Dataset/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ServiceID,ConsumerID,DatasetID,ProviderID,DatasetActivatedToUsedByService,GSBDatasetID,ImportingDate,VersionNumber,VersionDate,DataSourceName")] tb_Current_Intersection_Service_Dataset tb_Current_Intersection_Service_Dataset)
        {
            if (ModelState.IsValid)
            {
                db.tb_Current_Intersection_Service_Dataset.Add(tb_Current_Intersection_Service_Dataset);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DatasetID = new SelectList(db.tb_Current_MarsadDataset, "DatasetID", "DatasetFullName", tb_Current_Intersection_Service_Dataset.DatasetID);
            ViewBag.ServiceID = new SelectList(db.tb_Current_Service, "ServiceID", "ConsumerID", tb_Current_Intersection_Service_Dataset.ServiceID);
            return View(tb_Current_Intersection_Service_Dataset);
        }

        // GET: tb_Current_Intersection_Service_Dataset/Edit/5
        public ActionResult Edit(string ServiceID, int DatasetID )
        {
            if (ServiceID == null || DatasetID < 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Current_Intersection_Service_Dataset tb_Current_Intersection_Service_Dataset = db.tb_Current_Intersection_Service_Dataset.Find(ServiceID, DatasetID);
            if (tb_Current_Intersection_Service_Dataset == null)
            {
                return HttpNotFound();
            }
            ViewBag.DatasetID = new SelectList(db.tb_Current_MarsadDataset, "DatasetID", "DatasetFullName", tb_Current_Intersection_Service_Dataset.DatasetID);
            ViewBag.ServiceID = new SelectList(db.tb_Current_Service, "ServiceID", "ConsumerID", tb_Current_Intersection_Service_Dataset.ServiceID);
            return View(tb_Current_Intersection_Service_Dataset);
        }

        // POST: tb_Current_Intersection_Service_Dataset/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ServiceID,ConsumerID,DatasetID,ProviderID,DatasetActivatedToUsedByService,GSBDatasetID,ImportingDate,VersionNumber,VersionDate,DataSourceName")] tb_Current_Intersection_Service_Dataset tb_Current_Intersection_Service_Dataset)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_Current_Intersection_Service_Dataset).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DatasetID = new SelectList(db.tb_Current_MarsadDataset, "DatasetID", "DatasetFullName", tb_Current_Intersection_Service_Dataset.DatasetID);
            ViewBag.ServiceID = new SelectList(db.tb_Current_Service, "ServiceID", "ConsumerID", tb_Current_Intersection_Service_Dataset.ServiceID);
            return View(tb_Current_Intersection_Service_Dataset);
        }

        // GET: tb_Current_Intersection_Service_Dataset/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Current_Intersection_Service_Dataset tb_Current_Intersection_Service_Dataset = db.tb_Current_Intersection_Service_Dataset.Find(id);
            if (tb_Current_Intersection_Service_Dataset == null)
            {
                return HttpNotFound();
            }
            return View(tb_Current_Intersection_Service_Dataset);
        }

        // POST: tb_Current_Intersection_Service_Dataset/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            tb_Current_Intersection_Service_Dataset tb_Current_Intersection_Service_Dataset = db.tb_Current_Intersection_Service_Dataset.Find(id);
            db.tb_Current_Intersection_Service_Dataset.Remove(tb_Current_Intersection_Service_Dataset);
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
