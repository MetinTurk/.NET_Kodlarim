using System;
using System.Collections.Generic;
using System.Text;

namespace FinalSorusuTekrar
{
    internal class Ogrenci<TKey> : BaseEntity<int>
    {
        public string Ad { get; set; }
        public string  Soyad { get; set; }
        public string OgrenciNo { get; set; }


    }
}
