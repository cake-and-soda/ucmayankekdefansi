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
           
            return View();
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
        public ActionResult Guncelle()
        {

            return View();
        }
        public ActionResult Sil()
        {
            return View();
        }
    }
}