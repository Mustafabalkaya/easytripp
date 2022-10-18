using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tatil_Seyahat_Sitesi.Models.Sınıflar
{
    public class Plaj
    {
        [Key]
        public int id { get; set; }
        public string plaj_link { get; set; }
        public string plaj_aciklama { get; set; }
    }
}