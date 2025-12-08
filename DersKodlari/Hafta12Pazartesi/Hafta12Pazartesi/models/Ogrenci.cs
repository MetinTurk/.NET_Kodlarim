using System;
using System.Collections.Generic;
using System.Text;

namespace Hafta12Pazartesi.models
{
    public class Ogrenci
    {
        //içerisinde static özelliği taşır.
        public const string Universite = "ISUBU";
        private static int sayi;
        private int sayi2;
        public static int Sayi3 { get; set; }
        public static int OgrenciSayisi { get; set; }
        public Ders Ders { get; set; }

        //override edilmez ve parametre gönderemeyiz, static constractor sadece program çalıştığında bir kere çalışır.
        //ilk static ctor calisir.
        //staticlik bulaşıcıdır. ve overload'u yoktur.
        static Ogrenci()
        {
            sayi = 0;
            Sayi3 = 0;
            Console.WriteLine("Static ctor calisti");
            Konus();
            //YemekYe();    //static olmadığı için çağıramayız
        }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Ogrenci(string ad, string soyad)
        {
            Console.WriteLine("Normal ctor calisti");
            this.Ad = ad;
            this.Soyad = soyad;
            OgrenciSayisi++;
        }

        ~Ogrenci()
        {
            OgrenciSayisi--;

        }


        public static void Konus()
        {
            sayi++;
            Sayi3++;
            //sayi2     //erişemeyiz
        }

        public void YemekYe()
        {
            //static olmayan methodlarda hepsine erişebiliriz
            sayi++;
            Sayi3++;
            sayi2++;

        }

        public void KendiniTanit()
        {
            try
            {
                Console.WriteLine(Ders);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ders ataması yapılmamış");
                //throw;      //hatayı çağırıldığı yere geri döndürür
                throw new IsubuException("Ders ataması yapılmamış");
            }
            finally //eğer throw varsa kullanmamız gerekli çünkü throw yaptığımız için finally çalışıp kalan kodları umursamaz
            {
                Console.WriteLine($"Benim adım {Ad}");
            }
            Console.WriteLine($"Benim adım 2 {Ad}");
        }
    }
}
