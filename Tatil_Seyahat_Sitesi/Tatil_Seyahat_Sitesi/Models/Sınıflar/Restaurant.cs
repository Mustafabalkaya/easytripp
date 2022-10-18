using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tatil_Seyahat_Sitesi.Models.Sınıflar
{
    public class Restaurant
    {
        [Key]
        public int id { get; set; }
        public string ekleme_restaurant { get; set; }
        public string ekleme_aciklama { get; set; }
    }
}