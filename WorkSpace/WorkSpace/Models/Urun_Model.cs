using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorkSpace.Models
{
    public class Urun_Model
    {
        [Key]
        public int Urun_Id { get; set; }
        public string Ad { get; set; }
        public string Kod { get; set; }
        public string Detay { get; set; }
    }
    public class UrunRenk_Model
    {
        [Key]
        public int Renk_Id { get; set; }
        public int Urun_Id { get; set; }
        public string Renk { get; set; }

    }
    public class UrunBeden_Model
    {
        [Key]
        public int Beden_Id { get; set; }
        public int Renk_Id { get; set; }
        public string Beden_boyutu { get; set; }
        public int Stok { get; set; }

    }
    public class Urun_Resim
    {
        [Key]
        public int Resim_Id { get; set; }
        public int Renk_Id { get; set; }
        public string Resim_Yolu { get; set; }
    }
}