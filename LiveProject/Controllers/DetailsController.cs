using LiveProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LiveProject.Controllers
{
    public class DetailsController : Controller
    {
        private TopMortgageEntities _db = new TopMortgageEntities();
        // GET: Details
        public ActionResult Index()
        {
            CustDetail model = new CustDetail();
            return View(model);
        }
        public ActionResult Cust(CustDetail model)
        {
            _db.CustDetails.Add(model);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Requestacallback(RequestaCallBack model)
        {
            _db.RequestaCallBacks.Add(model);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}