using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tatil_Seyahat_Sitesi.Models.Sınıflar;

namespace Tatil_Seyahat_Sitesi.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        Blogyorum by = new Blogyorum();

        public ActionResult Index()
        {
            // var bloglar = c.blogs.ToList();
            by.Deger1 = c.blogs.ToList();
            by.Deger3 = c.blogs.Take(3).ToList();

            return View(by);
        }
        public ActionResult BlogDetay(int id)
        {

            //var blogbul = c.blogs.Where(x => x.id ==id).ToList();
            by.Deger1 = c.blogs.Where(x => x.id == id).ToList();
            by.Deger2 = c.yorumlars.Where(x => x.Blogid == id).ToList();
            return View(by);
        }
        [HttpGet]
        public PartialViewResult YorumYap( int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult YorumYap(yorumlar y)
        {
            c.yorumlars.Add(y);
            c.SaveChanges();
            return PartialView();
        }
      
    }
}