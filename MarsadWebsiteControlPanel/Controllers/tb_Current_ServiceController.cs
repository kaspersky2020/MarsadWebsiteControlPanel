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
    public class tb_Current_ServiceController : Controller
    {
        private MarsadWebsiteControlPanelEntities db = new MarsadWebsiteControlPanelEntities();

        // GET: tb_Current_Service
        public ActionResult Index()
        {
            return View(db.tb_Current_Service.ToList());
        }

        // GET: tb_Current_Service/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Current_Service tb_Current_Service = db.tb_Current_Service.Find(id);
            if (tb_Current_Service == null)
            {
                return HttpNotFound();
            }
            return View(tb_Current_Service);
        }

        // GET: tb_Current_Service/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tb_Current_Service/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ConsumerID,AgencyName,ServiceID,ServiceArabicName,ServiceEnglishName,DepartmentName,ServiceTypeID,ServiceClassificationID,ServiceGeographicalCoverageID,ServicePriorityID,ServiceFees,FinancedByYesser,TimeTakenToDelivereTheServiceNow,TimeTakenToDelivereTheServiceInFuture,OutsideBranchesToProvideTheService,DigitalCertificateIssued,ServiceMaturityLevelID,HigherMaturityServiceLevelToBeReachedID,HigriDateForTransmissitingServiceToTopMaturityLevel,GregorianDateForTransmissitingServiceToTopMaturityLevel,ServiceTargetAudienceNumberID,ServiceNumberOfBeneficiariesInElectronicFormAnnuallyID,ServiceNumberOfElectronicTransactionsPerYearID,ServiceRepeatedNumberOfUsePerBeneficiaryID,ServiceAutomationPortabilityInItsCurrentStateID,ServiceRequirementsAndProceduresForServiceAvailableID,ServiceHasDocumentedProceduresID,ServiceHasWorkflowChartID,ServiceHasProcessReengineeredID,ServiceHasUnifiedProcessesID,ArabicHyperLink,EnglishHyperLink,YouTubeLink,ServiceManual,ServiceForm,ServiceArabicDescription,ServiceEnglishDescription,NumberOfServiceRequestProcessedManuallyIn6Months,NumberOfServiceRequestProcessedElectronically6Months,MyComments,ImportingDate,VersionNumber,VersionDate,DataSourceName,ActionTaken")] tb_Current_Service tb_Current_Service)
        {
            if (ModelState.IsValid)
            {
                db.tb_Current_Service.Add(tb_Current_Service);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_Current_Service);
        }

        // GET: tb_Current_Service/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Current_Service tb_Current_Service = db.tb_Current_Service.Find(id);
            if (tb_Current_Service == null)
            {
                return HttpNotFound();
            }
            return View(tb_Current_Service);
        }

        // POST: tb_Current_Service/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ConsumerID,AgencyName,ServiceID,ServiceArabicName,ServiceEnglishName,DepartmentName,ServiceTypeID,ServiceClassificationID,ServiceGeographicalCoverageID,ServicePriorityID,ServiceFees,FinancedByYesser,TimeTakenToDelivereTheServiceNow,TimeTakenToDelivereTheServiceInFuture,OutsideBranchesToProvideTheService,DigitalCertificateIssued,ServiceMaturityLevelID,HigherMaturityServiceLevelToBeReachedID,HigriDateForTransmissitingServiceToTopMaturityLevel,GregorianDateForTransmissitingServiceToTopMaturityLevel,ServiceTargetAudienceNumberID,ServiceNumberOfBeneficiariesInElectronicFormAnnuallyID,ServiceNumberOfElectronicTransactionsPerYearID,ServiceRepeatedNumberOfUsePerBeneficiaryID,ServiceAutomationPortabilityInItsCurrentStateID,ServiceRequirementsAndProceduresForServiceAvailableID,ServiceHasDocumentedProceduresID,ServiceHasWorkflowChartID,ServiceHasProcessReengineeredID,ServiceHasUnifiedProcessesID,ArabicHyperLink,EnglishHyperLink,YouTubeLink,ServiceManual,ServiceForm,ServiceArabicDescription,ServiceEnglishDescription,NumberOfServiceRequestProcessedManuallyIn6Months,NumberOfServiceRequestProcessedElectronically6Months,MyComments,ImportingDate,VersionNumber,VersionDate,DataSourceName,ActionTaken")] tb_Current_Service tb_Current_Service)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_Current_Service).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_Current_Service);
        }

        // GET: tb_Current_Service/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Current_Service tb_Current_Service = db.tb_Current_Service.Find(id);
            if (tb_Current_Service == null)
            {
                return HttpNotFound();
            }
            return View(tb_Current_Service);
        }

        // POST: tb_Current_Service/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            tb_Current_Service tb_Current_Service = db.tb_Current_Service.Find(id);
            db.tb_Current_Service.Remove(tb_Current_Service);
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
