using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkSpace.Models;

namespace WorkSpace.Controllers
{
    public class YonetimController : Controller
    {
        VtContex vt_islemleri = new VtContex();
        // GET: Yonetim
        public ActionResult Liste()
        {
<<<<<<< HEAD
            return View(vt_islemleri.Urun.ToList());
=======
            vt_Listeler.UrunList = vt_islemleri.Urun.ToList();
            return View();
>>>>>>> 26f192c6c91999379d43c22ed098af714040762d
        }
        public ActionResult Ekle()
        {
            return View();
        }
        public ActionResult Ekle1(Urun_Model gelen)
        {
            vt_islemleri.Urun.Add(gelen);
            vt_islemleri.SaveChanges();
            return View("Ekle");
        }
        public ActionResult Guncelle(int Id)
        {

            return View(Id);
        }
        public ActionResult Sil()
        {
            return View();
        }
    }
}