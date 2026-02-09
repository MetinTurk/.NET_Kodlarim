using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace FinalSorusu
{
    public class Ogrenci : BaseEntity<int>
    {
        
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string OgrenciNo { get; set; }


    }
}
