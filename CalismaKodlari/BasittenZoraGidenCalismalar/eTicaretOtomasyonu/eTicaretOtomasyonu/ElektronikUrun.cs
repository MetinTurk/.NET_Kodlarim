using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace eTicaretOtomasyonu
{
    internal class ElektronikUrun : Urun
    {
        private double _ovtOrani;

        public ElektronikUrun(string urunAdi , double temelFiyat , double otvOrani) : base(urunAdi , temelFiyat)
        {
            this._ovtOrani = otvOrani;
        }

        public override void BilgileriGoster()
        {
            Console.WriteLine($"Ürün adı : {this.UrunAdi} , ürün fiyatı: {this.FiyatHesapla()} ₺ , otv Oranı: {this._ovtOrani}");
        }

        public override double FiyatHesapla()
        {
            return ((this.TemelFiyat * this._ovtOrani) / 100) + this.TemelFiyat; 
        }

        
    }
}
