using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceveErisimBelirleyiciler.Recusive_OOP
{
    internal class Calisan
    {
        public string Ad { get; set; }
        public decimal Maas { get; }

        public Calisan()
        {
            altCalisanlar = new List<Calisan>();
        }

        List<Calisan> altCalisanlar;
        public decimal ToplamMaliyet()
        {
            decimal toplam = this.Maas;
            foreach (var calisan in altCalisanlar)
            {
                 toplam += calisan.ToplamMaliyet();
            }
            return toplam;
        }

        public double GuvenliBolme(int bolunen , int bolen)
        {
            try
            {
                return (double)bolunen / bolen;
            }
            catch (DivideByZeroException)
            {
                return -1;
                throw new Exception("Hata: Sıfıra bölme yapılamaz!");
            }
        }




    }
}
