using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceveErisimBelirleyiciler
{
    internal class Depo<T> where T : IUrun, new()
    {
        public List<T> Urunler;
        public Depo()
        {
            this.Urunler = new List<T>();
        }

        public void Ekle(T eklenecekVeri)
        {
            Urunler.Add(eklenecekVeri);
        }

        public List<T> TumunuGetir()
        {
            return this.Urunler;
        }

        public decimal ToplamStokDegeri()
        {
            decimal toplam = 0;
            foreach (var urun in Urunler)
            {
                toplam += urun.Fiyat;
            }
            return toplam;
        }

        public void PromosyonUrunuEkle()
        {
            T nesne = new T();
            nesne.UrunAdi = "Promosyon Ürünü";
            Urunler.Add(nesne);
        }
    }
}
