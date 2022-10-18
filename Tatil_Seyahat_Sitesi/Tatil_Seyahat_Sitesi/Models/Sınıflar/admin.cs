using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tatil_Seyahat_Sitesi.Models.Sınıflar
{
    public class admin
    {
        [Key]
        public int id { get; set; }
        public string kullanici { get; set; }
        public string sifre { get; set; }



    }
}