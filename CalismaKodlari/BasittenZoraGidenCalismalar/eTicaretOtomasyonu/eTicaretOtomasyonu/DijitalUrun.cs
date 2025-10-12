using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTicaretOtomasyonu
{
    internal class DijitalUrun : Urun
    {
        public DijitalUrun(string urunAdi , double temelFiyat) : base(urunAdi , temelFiyat) 
        {
                
        }

        public override double FiyatHesapla()
        {
            return this.TemelFiyat;
        }

        public override void BilgileriGoster()
        {
            Console.WriteLine($"Ürün adı : {this.UrunAdi} , ürün fiyatı: {this.FiyatHesapla()} ₺, vergisi yok (muaf)");
        }
    }
}
