using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YardımEliWeb.Models.Entity;


namespace YardımEliWeb.Controllers
{
    public class ObjectDonaterController : Controller
    {
        //Database'imizi tanımladık.
        dbYardımEliDonatersEntities db = new dbYardımEliDonatersEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult EsyaBagisYap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EsyaBagisYap(tblEsyaBagiscilari esyaDonaters)
        {
            db.tblEsyaBagiscilari.Add(esyaDonaters); //Değişken yardımıyla tablonun içine bilgileri aktardık.
            db.SaveChanges();//Database'e kaydetme işlemi tamamlandı.
            return View();
        }
    }
}