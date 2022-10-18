using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tatil_Seyahat_Sitesi.Models.Sınıflar
{
    public class tavsiyeler
    {
        [Key]
        public int id { get; set; }
        public string tavsiye_otel { get; set; }
        public string tavsiye_aciklama { get; set; }
    }
}