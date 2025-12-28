using System;
using System.Collections.Generic;
using System.Text;

namespace EsnekOdemeSistemi
{
    internal class Urunler
    {
        public string Adi { get; }
        public int Fiyat { get; }
        public Urunler(string adi , int fiyati) 
        {
            this.Adi = adi;
            this.Fiyat = fiyati;
        }
    }
}
