using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTicaretOtomasyonu
{
    internal class Urun
    {
        private string _urunAdi;
        private double _temelFiyat;

        public Urun(string urunAdi , double temelFiyat) 
        {
            this._urunAdi = urunAdi;
            this._temelFiyat = temelFiyat;
        }

        public string UrunAdi { get => _urunAdi;}
        public double TemelFiyat { get => _temelFiyat;}

        public virtual double FiyatHesapla()
        {
            return _temelFiyat;
        }

        public virtual void BilgileriGoster()
        {
            Console.WriteLine($"Ürün adı : {this._urunAdi} , ürün fiyatı: {this._temelFiyat} ₺");
        }
            
    }
}
