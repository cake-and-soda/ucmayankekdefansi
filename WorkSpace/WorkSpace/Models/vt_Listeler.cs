using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkSpace.Models
{
    public class vt_Listeler
    {
        public static List<Urun_Model> UrunList { get; set; }
        public static List<UrunRenk_Model> UrunRenkList { get; set; }
        public static List<UrunBeden_Model> UrunBedenList { get; set; }
        public static List<Urun_Resim> UrunResimList { get; set; }
    }
}