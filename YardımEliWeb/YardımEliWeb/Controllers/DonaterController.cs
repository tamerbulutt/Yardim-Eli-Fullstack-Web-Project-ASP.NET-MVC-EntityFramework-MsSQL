using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YardımEliWeb.Models.Entity;

namespace YardımEliWeb.Controllers
{
    public class DonaterController : Controller
    {
        //Database'imizi tanımladık.
        dbYardımEliDonatersEntities db = new dbYardımEliDonatersEntities(); 
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult BagisYap()
        {
            return View();
        }
 
        [HttpPost]
        public ActionResult BagisYap(tblDonaters bagis)
        {           
            db.tblDonaters.Add(bagis);//tblDonaters tablosu içine bagis değiskeni altında verileri yazdırdık.
            db.SaveChanges(); //Database'e kaydetmeyi sağladık.
            return View();
        }    
    }
}