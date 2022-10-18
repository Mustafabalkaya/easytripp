using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tatil_Seyahat_Sitesi.Models.Sınıflar;

namespace Tatil_Seyahat_Sitesi.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c =new Context();
        public ActionResult Index()
        {
            var degerler = c.blogs.Take(8).ToList();

            return View(degerler);
        }
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            var degerler = c.blogs.OrderByDescending(x => x.id).Take(2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial2()
        {
            var deger =c.blogs.Where(x=> x.id == 2).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial3()
        {
            var deger = c.blogs.Take(10).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial4()
        {
            var deger = c.blogs.Take(3).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial5()
        {
            var degerler = c.blogs.Take(3).OrderByDescending(x => x.id).ToList();
            return PartialView(degerler);
        }
        public ActionResult iletisim()
        {
            return View();
        }
    }
}