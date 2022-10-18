using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tatil_Seyahat_Sitesi.Models.Sınıflar;
namespace Tatil_Seyahat_Sitesi.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.blogs.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog(blog p)
        {
            c.blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id )
        {
            var b=c.blogs.Find(id);
            c.blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogGetir(int id)
        {
            var b1 = c.blogs.Find(id);
            return View("BlogGetir",b1);
        }
        public ActionResult BlogGuncelle(blog b)
        {
            var blg = c.blogs.Find(b.id);
            blg.aciklama = b.aciklama;
            blg.baslik=b.baslik;
            blg.BlogImage=b.BlogImage;
            blg.tarih=b.tarih;
            c.SaveChanges();
            return RedirectToAction("Index");   
           
        }
        public ActionResult YorumListesi()
        {
            var yorumlar=c.yorumlars.ToList();
            return View(yorumlar);
        }
        public ActionResult YorumSil(int id)
        {
            var b = c.yorumlars.Find(id);
            c.yorumlars.Remove(b);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        public ActionResult YorumGetir(int id)
        {
            var y = c.yorumlars.Find(id);
            return View("YorumGetir", y);

        }
        public ActionResult YorumGuncelle(yorumlar y)
        {
            var yrm = c.yorumlars.Find(y.id);
            yrm.kullaniciadi = y.kullaniciadi;
            yrm.mail = y.mail;
            yrm.yorum = y.yorum;           
            c.SaveChanges();
            return RedirectToAction("YorumListesi");

        }
        public ActionResult hakkimizda()
        {
            return View();
        }

    }
}