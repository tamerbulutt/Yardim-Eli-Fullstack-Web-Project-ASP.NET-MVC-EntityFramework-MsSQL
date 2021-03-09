using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YardımEliWeb.Models.Entity;
namespace YardımEliWeb.Controllers
{
    public class BilgilendirmeController : Controller
    {       
        public ActionResult Bilgilendirme()
        {
            return View();
        }

        public ActionResult Info()
        {
            using(dbYardımEliDonatersEntities db = new dbYardımEliDonatersEntities())
            {
                // tblBilgilendirme tablosundaki tüm verileri çekiyoruz.
                var model = db.tblBilgilendirme.ToList();
                return View(model); //View içine çektiğimiz veriyi yansıtıyoruz.
            }
        }
    }
}