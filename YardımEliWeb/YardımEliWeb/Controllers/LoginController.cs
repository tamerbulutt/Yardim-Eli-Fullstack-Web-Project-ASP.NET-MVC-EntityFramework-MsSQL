using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using YardımEliWeb.Models.Entity;

namespace YardımEliWeb.Controllers
{
    public class LoginController : Controller
    {
        //Database'imizi tanımladık.
        dbYardımEliDonatersEntities db = new dbYardımEliDonatersEntities();
        public ActionResult Giris()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Giris(tblKullanıcılar admin)
        {
            //Girilen kullanıcı adı ve şifre ile database'dekilerin denkleştirilmesi yapıldı.
            var adminBilgi = db.tblKullanıcılar.FirstOrDefault(x => x.kullanıcıAdı == admin.kullanıcıAdı && x.kullanıcıSifre == admin.kullanıcıSifre);
            if (adminBilgi != null) //Eğer girilenler ile databasedekiler uyuşuyorsa
            {
                FormsAuthentication.SetAuthCookie(adminBilgi.kullanıcıAdı, false); //Aktif kullanıcı belirlendi
                return RedirectToAction("DonateList", "AllDonates"); // Ve içeri giriş sağlandı
            }
            else
            {
                return View(); // Uyuşmuyorsa tekrardan View'a dönüş sağlandı.
            }

        }
    }
}