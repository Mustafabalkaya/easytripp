using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tatil_Seyahat_Sitesi.Models.Sınıflar
{
    public class Blogyorum
    {
        public IEnumerable<blog> Deger1 { get; set; }
        public IEnumerable<yorumlar> Deger2 { get; set; }
        public IEnumerable<blog> Deger3 { get; set; }
        public IEnumerable<tavsiyeler> Deger4 { get; set; }
        public IEnumerable<Restaurant> Deger5 { get; set; }
        public IEnumerable<Plaj> Deger6 { get; set; }



    }
}