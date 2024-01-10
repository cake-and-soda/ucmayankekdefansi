using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        public ActionResult Ekle()
        {
            //sa burası urun ekleme sayfası niggalar
            return View();
        }
        public ActionResult Ekle (Urun urun)
        {
            //burada ürün de kaydediyoz veri tabanınada kaydediyoz kaliteli yeri niggalar
            // _context.Urunler.Add(urun);
            // _context.SaveChanges();
            return RedirectToAction("Liste");
        }

        public ActionResult Duzenle (int id)
        {
            //burası ürün düzenleme sayfası niggalar
            return View();
        }
        public ActionResult Duzenle (Urun urun)
        {
            //güncelleme yapıyoruz ayrıca veri tabanı güncelleme burada niggalar 
            return RedirectToAction("Liste");
        }
        //daha da yazmıyorum zaten biliyonuz

        public ActionResult Sil (int id)
        {
            return RedirectToAction("Liste");
        } 
        public ActionResult Liste ()
        {
            return View();
        }

    }
}