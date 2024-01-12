using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WorkSpace.Models
{
    public class VtContex : DbContext
    {
        public VtContex() : base("UrunlerDB"){}
        public DbSet<Urun_Model> Urun { get; set; }
        public DbSet<UrunRenk_Model> UrunRenk { get; set; }
        public DbSet<UrunBeden_Model> UrunBeden { get; set; }
        public DbSet<Urun_Resim> UrunResim { get; set; }
    }
}