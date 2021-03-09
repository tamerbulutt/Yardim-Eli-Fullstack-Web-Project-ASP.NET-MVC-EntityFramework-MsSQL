using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YardımEliWeb.Models.Entity;
using YardımEliWeb.Models.MyClass;

namespace YardımEliWeb.Controllers
{
    public class DefaultController : Controller
    {
        
        public ActionResult Index()
        {
            
            dbYardımEliDonatersEntities db = new dbYardımEliDonatersEntities(); //Database'imizi tanımladık.           
            HizmetVeHikayeler hizmetHikaye = new HizmetVeHikayeler(); //HizmetVeHikayeler sınıfımızdan nesne ürettik.          
           
            hizmetHikaye.hikayeDeger = db.tblHikayeler.ToList(); //hikaye için tblHikayeler'deki verileri çektik         
            hizmetHikaye.hizmetDeger = db.tblHizmetler.ToList(); //hizmet için tblHizmet'teki verileri çektik.
           
            return View(hizmetHikaye);
        }
    }
}