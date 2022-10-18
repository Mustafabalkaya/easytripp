using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Tatil_Seyahat_Sitesi.Models.Sınıflar
{
    public class Context:DbContext
    {
        public DbSet<admin>admins { get; set; }
        public DbSet<adresblog> adresblogs { get; set; }
        public DbSet<blog> blogs { get; set; }
        public DbSet<hakkimizda> hakkimizdas { get; set; }
        public DbSet<iletisim> iletisims { get; set; }
        public DbSet<yorumlar> yorumlars { get; set; }
        public DbSet<tavsiyeler> tavsiyelers { get; set; }
        public DbSet<Restaurant> restaurants { get; set; }
        public DbSet<Plaj> plajs { get; set; }
        
    }
}