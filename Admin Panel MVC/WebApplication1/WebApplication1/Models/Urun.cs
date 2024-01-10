using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Urun
    {
        public int urunId { get; set; }
        public string Ad { get; set; }
        public string Kod { get; set; }
        public string Detay { get; set; }

        public List<UrunRenk> Renkler { get; set; }
    }

    public class UrunRenk
    {
        public int RenkId { get; set; }
        public int UrunId { get; set; }
        public string Renk { get; set; }

        public List<UrunBeden> Bedenler { get; set; }
    }
    
    public class UrunBeden
    {
        public int BedenId { get; set; }
        public int RenkId { get; set; }
        public string BedenBoyutu { get; set; }
        public string Stok { get; set; }
    }


    public class UrunResim
    {
        public int ResimId { get; set; }
        public int RenkId { get; set; }
        public string  ResimYolu { get; set; }
    }
}