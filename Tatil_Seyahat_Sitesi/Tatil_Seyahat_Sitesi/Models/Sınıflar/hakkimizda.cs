using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tatil_Seyahat_Sitesi.Models.Sınıflar
{
    public class hakkimizda
    {
        [Key]
        public int id { get; set; }
        public string fotourl { get; set; }
        public string aciklama { get; set; }
    }
}