using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTicaretOtomasyonu
{
    internal class GiyimUrunu : Urun
    {
        private double _kdvOrani;

        public GiyimUrunu(string urunAdi, double temelFiyat, double kdvOrani) : base(urunAdi, temelFiyat)
        {
            this._kdvOrani = kdvOrani;
        }

        public override double FiyatHesapla()
        {
            return ((this.TemelFiyat * this._kdvOrani) / 100) + this.TemelFiyat;
        }

        public override void BilgileriGoster()
        {
            Console.WriteLine($"Ürün adı : {this.UrunAdi} , ürün fiyatı: {this.FiyatHesapla()} ₺ , kdv Oranı: {this._kdvOrani}");
        }

    }
}
