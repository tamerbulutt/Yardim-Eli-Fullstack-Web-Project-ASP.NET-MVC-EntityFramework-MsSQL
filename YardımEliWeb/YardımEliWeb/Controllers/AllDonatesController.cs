using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using YardımEliWeb.Models.Entity;

namespace YardımEliWeb.Controllers
{
    
    public class AllDonatesController : Controller
    {
        //Database'imizi tanımlıyoruz.
        dbYardımEliDonatersEntities db = new dbYardımEliDonatersEntities();
        public ActionResult Donates()
        {
            return View();
        }
        //Hangi rollerin girebileceğini Authorize işlemi ile gerçekleştirdik.
        [Authorize(Roles = "GenelMüdür,Personel")]
        public ActionResult DonateList()
        {
             using(dbYardımEliDonatersEntities db = new dbYardımEliDonatersEntities())
             {
                //Database'imizdeki tblDonaters tablosunu listelemesini sağladık.
                var model = db.tblDonaters.ToList();
                return View(model);
            }
            
        }
        public ActionResult Delete(int id)
        {
            // Kullanıcının ID'sine göre gidip o tablodaki tüm verilerini silme işlemini sağlıyor.
            var donater = db.tblDonaters.Find(id);
            db.tblDonaters.Remove(donater); //Tablodan silindi.
            db.SaveChanges(); //Database'e kaydetme işlemi sağlandı.
            return RedirectToAction("DonateList");
        }
        [HttpGet]
        public ActionResult GetDonaterInfo(int id)
        {
            //Kullanıcının ID'sine o tablodaki bilgilerini çekiyor.
            var donaterInfo = db.tblDonaters.Find(id);
            return View("GetDonaterInfo", donaterInfo);
        }

        [HttpPost]
        public ActionResult Update(tblDonaters donater)
        {
            var donaterForUpdate = db.tblDonaters.Find(donater.ID); //ID'sine göre kullanıcıyı bulduk.

            donaterForUpdate.Ad = donater.Ad;
            donaterForUpdate.Soyad = donater.Soyad;
            donaterForUpdate.Eposta = donater.Eposta;
            donaterForUpdate.KrediKartNo = donater.KrediKartNo;
            donaterForUpdate.Sehir = donater.Sehir;
            donaterForUpdate.Miktar = donater.Miktar;
            //Kullanıcının verilerini yeni girilenlerle güncelledik.
            db.SaveChanges(); //Database'e kaydetme işlemini yaptık.
            return RedirectToAction("DonateList");
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut(); //Çıkış sağlanıyor , artık aktif kullanıcı yok.
            return RedirectToAction("Index", "Default");
        }
    }
}