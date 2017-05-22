using LiveProject.Models;
using System.Web.Mvc;
using System.Data.Entity;



namespace LiveProject.Controllers
{
    public class HomeController : Controller
    {
        private TopMortgageEntities _db = new TopMortgageEntities();
        // GET: Home

        [HttpGet]
        public ActionResult Index()
        {
            CustDetail model = new CustDetail();
            return View(model);
        }


        [HttpPost]
        public ActionResult Cust(CustDetail model)
        {
            _db.CustDetails.Add(model);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult RequestCallBack(RequestaCallBack model)
        {
            _db.RequestaCallBacks.Add(model);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

    
