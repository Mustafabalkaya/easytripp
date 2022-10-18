using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tatil_Seyahat_Sitesi.Models.Sınıflar
{
    public class blog
    {
        [Key]
        public int id { get; set; }
        public string baslik { get; set; }
        public DateTime tarih { get; set; }
        public string  aciklama { get; set; }
        public string BlogImage { get; set; }
        public ICollection<yorumlar>yorumlars { get; set; }
    }
}