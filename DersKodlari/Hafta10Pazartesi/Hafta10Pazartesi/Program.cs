using Hafta10Pazartesi.models;
using Hafta10Pazartesi.Ortak;

namespace Hafta10Pazartesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //int sayi = 1;
            ////Urun urun = new Urun();
            //var urun2 = new Urun(23);
            ////var urun3 = new Urun("Asus Desktop");
            //var urun4 = new Urun(2,"Asus Desktop");


            ////Urun urun5 = new();
            //Urun urun6 = new(233);


            //Kisi kisi = new Kisi()
            //{
            //    Ad = "Sila",
            //    Soyad = "Türk"
            //};


            Kisi kisi = new Kisi("Sila", "Türk");


            //Isci metin = new Isci()
            //{
            //    Ad = "Metin",
            //    Soyad = "Türk",
            //    YapilanIs = "Elektrik İşleri"
            //};

            Isci metin = new Isci("Metin", "Türk")
            {
                YapilanIs = "Elektrik İşleri"
            };

            Isci mehmet = new Isci()
            {
                YapilanIs = "Elektrik İşleri"
            };

            metin.KendiniTanit();
            metin.Calis();
            metin.YemekYe();
            metin.Calis();
            metin.Uyu();

            Console.WriteLine(metin);       //namespace'ini yazar.  toString() fonks. override etmeden önce

            Marka marka = new Marka("HP");
            //marka.MarkayiTanit();     //internal
            //Model model = new Model("HP");    //internal // aynı klasor içerisinde kullanılabilir fakat farklı bir klasor içerisinden çağrılamaz.





        }
    }
}
