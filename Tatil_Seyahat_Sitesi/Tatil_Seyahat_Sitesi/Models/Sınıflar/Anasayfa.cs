using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tatil_Seyahat_Sitesi.Models.Sınıflar
{
    public class Anasayfa
    {
        [Key]
        public int id { get; set; }
        public string baslik { get; set; }
        public string aciklama { get; set; }
    }
}