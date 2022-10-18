using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tatil_Seyahat_Sitesi.Models.Sınıflar;

namespace Tatil_Seyahat_Sitesi.Controllers
{
    public class PlajController : Controller
    {
        // GET: Plaj
        Context c = new Context();
        Blogyorum by = new Blogyorum();
        public ActionResult Index()
        {
            by.Deger6 = c.plajs.ToList();


            return View(by);
        }
    }
}