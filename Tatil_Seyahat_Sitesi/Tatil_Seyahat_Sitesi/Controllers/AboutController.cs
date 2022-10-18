using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tatil_Seyahat_Sitesi.Models.Sınıflar;

namespace Tatil_Seyahat_Sitesi.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        Context c = new Context();


        public ActionResult Index()
        {
            var degerler = c.hakkimizdas.ToList();
            return View(degerler);
        }
    }
}