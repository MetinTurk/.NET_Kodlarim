using System;
using System.Collections.Generic;
using System.Text;

namespace Hafta10Pazartesi.models
{
    internal class Kisi
    {
        int id;                                     //default erişim belirteci : private olarak tanımlanır

        protected string tcKimlikNo;                //sınıfın dışarından kullanılmasın sadece benden türeyenler kalıtım alınanlar kullanabilsin demek
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public Kisi(string ad, string soyad = "SOYAD")        //opsiyonel parametre kullanılabilir.
        {
            Ad = ad;
            Soyad = soyad;
        }

        void Test()
        {

        }


        public void KendiniTanit()
        {
            Console.WriteLine($"Adım: {this.Ad} {this.Soyad}");
        }

        public void YemekYe()
        {
            Console.WriteLine("Yemek yiyorum.");
        }

        public virtual void Uyu()                   //override edebilmek için virtual yazabiliriz.
        {
            Console.WriteLine("Uyundu" + tcKimlikNo);
        }
        protected virtual void Gez()
        {
            Console.WriteLine("Gezdim.");
        }
    }

    internal class Isci : Kisi                      //tek bir sınıftan türetilebilir
    {
        public Isci(string ad, string soyad)
            : base(ad, soyad.ToUpper())
        {

        }

        public Isci()
            : base("Metin", "Türk")
        {

        }

        //public string Ad { get; set; }
        //public string Soyad { get; set; }

        public string YapilanIs { get; set; }

        //public void KendiniTanit()
        //{
        //    Console.WriteLine($"Adım: {this.Ad} {this.Soyad}");
        //}

        public void Calis()
        {
            Console.WriteLine("Çalışmaya başlandı");
            tcKimlikNo = "12315614537"; //erişebilidim.
        }

        public new void YemekYe()       //isim gizleme yaptık. base class'ımızda olan bir fonksiyona yapabiliriz.
        {
            base.YemekYe();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Yemek yiyorum İşci olarak.");
            }   
        }

        public override void Uyu()
        {
            //base.Uyu();
            Console.WriteLine("Daha az uyudum.");
            Gez();
        }

        protected override void Gez()
        {
            base.Gez();
        }

        public override string ToString()
        {
            return $"Ben {Ad} {Soyad}";
        }
    }

    public class Yonetici : Isci
    {

        public Yonetici(string ad, string soyad, string tcKimlikNo) 
            : base(ad, soyad)
        {
            this.tcKimlikNo = tcKimlikNo;
        }
    }

    class Stok  //defualt 
    {

    }
}
