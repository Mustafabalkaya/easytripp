using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tatil_Seyahat_Sitesi.Models.Sınıflar
{
    public class yorumlar
    {
        [Key]
        public int id { get; set; }
        public string kullaniciadi { get; set; }
        public string mail { get; set; }
        public string yorum { get; set; }
        public int Blogid { get; set; }
        public virtual blog blog { get; set; }




    }
}