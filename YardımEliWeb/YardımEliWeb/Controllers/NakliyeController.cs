using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YardımEliWeb.Models.Entity;


namespace YardımEliWeb.Controllers
{
    public class NakliyeController : Controller
    {
        //Database'imizi tanımladık.
        dbYardımEliDonatersEntities db = new dbYardımEliDonatersEntities();
        public ActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "GenelMüdür")] //Sadece rolü GenelMüdür olanların ulaşmasını sağladık.
        [HttpGet]
        public ActionResult NakliyeciEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NakliyeciEkle(tblNakliyeciler nakliye)
        {
            db.tblNakliyeciler.Add(nakliye); //tblNakliyeciler tablosuna girilen bilgilerin eklenmesini sağladık.
            db.SaveChanges(); //Database'e kaydetme işlemi tamamlandı.
            return View();
        }
    }
}