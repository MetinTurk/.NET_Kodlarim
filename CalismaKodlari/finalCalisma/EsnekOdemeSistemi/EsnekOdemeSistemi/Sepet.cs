using System;
using System.Collections.Generic;
using System.Text;

namespace EsnekOdemeSistemi
{
    internal class Sepet
    {
        List<Urunler> urunler = new List<Urunler>();
        double toplamFiyat = 0;
        public double ToplamFiyat { get; set; }
        
        public void SepeteEkle(Urunler urun)
        {
            toplamFiyat = 0;
            urunler.Add(urun);
            foreach (var alinanUrun in urunler)
            {
                toplamFiyat += alinanUrun.Fiyat;
            }
            ToplamFiyat = this.toplamFiyat;
        }

        

        public void Ode(IOdemeYontemi odemeYontemi)
        {
            odemeYontemi.Odeme(this.ToplamFiyat);
        }
    }
}
