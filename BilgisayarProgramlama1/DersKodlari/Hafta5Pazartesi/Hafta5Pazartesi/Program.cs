using System.Security.Cryptography;

namespace Hafta5Pazartesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region OR AND XOR
            ////&& and
            //// || or
            ////

            //var sirketSahibiMi = true;

            //var bakiye = 45;
            //var urunUcret = 50;
            //var yeterliBakiyeVarMi = bakiye >= urunUcret;

            //var satisYapilabilirMi = sirketSahibiMi || yeterliBakiyeVarMi;  // sadece 0 ve 0 da false olur.

            //var temizlikGorevlisiMi = true;
            //var cinsiyet = "Kadın";
            //var turnikeCinsiyet = "Kadın";

            //var gecisYapabilirMi = temizlikGorevlisiMi || (cinsiyet == turnikeCinsiyet && yeterliBakiyeVarMi);

            //var kosul1 = true;
            //var kosul2 = false;

            //var yadaCikis = kosul1 ^ kosul2;
            ////aynı değere sahipse false farklı ise true.
            ////  1   1   ->  0
            ////  0   1   ->  1
            ////  1   0   ->  1
            ////  0   0   ->  0 
            #endregion

            #region is , as , is null , is not null , ternary

            //object sayi = (long)23;
            ////object sayi = 23;
            //object metin = "23";

            ////var gercekSayi = (int)sayi;
            //var gercekMetin = (string)metin;

            //var sonuc = sayi is int;
            //sonuc = sayi is string;
            //sonuc = sayi is long;


            //sonuc = metin is string;
            //sonuc = metin is double;

            ////int sayi2 = (int)metin;



            ////as

            //string deger = metin as string;
            //long? deneme = null;
            //string? deneme2 = null;
            //long? deger2 = sayi as long?;         //as operatörü referans tipli veya null değer alabilen tiplerle çalışır.
            ////as  => eğer unboxing (cast) yapabilirsem değeri veririm. Ceviremezsem sana null değer döndürürüm
            //object sayi2 = 23.5;
            //int? deger3 = sayi2 as int?;
            //bool? deger4 = sayi2 as bool?;
            //double? deger5 = sayi2 as double?;
            //float? deger6 = sayi2 as float?;

            //var deger6DegerVarMi = deger6.HasValue;      //Değeri var mı yok mu ?    (true döndü)
            //var deger5DegerVarMi = deger5.HasValue;      //(false döndü çünkü null)


            //deger6DegerVarMi = deger6 != null;      //(true döndü null dan farklı)
            //deger5DegerVarMi = deger5 != null;      //(false döndü çünkü null)

            //var deger6NullMi = deger6 == null;      
            //var deger5NullMi = deger5 == null;

            //deger6DegerVarMi = deger6 is not null;      
            //deger5DegerVarMi = deger5 is not null;      

            //deger6NullMi = deger6 is null;
            //deger5NullMi = deger5 is null;


            ////dikey dilme veya birden fazla imleç yapmak için alt tuşuna basılı tutup seçimimizi yapıyoruz..


            ////ternary

            //var kosul = false;

            //var mesaj = kosul ? "Hoşgeldiniz." : "Geçme yetkiniz yoktur.";      //? true olduğunda çalışır("Hoşgeldiniz.") : false olduğunda çalışır("Geçme yetkiniz yoktur.");

            //var sonuc4 = kosul ? 23 : 45;           //45 değeri atandı.    
            //var sonuc5 = kosul ? 23.4 : 45.7;       //geri dönüş tiplerinin aynı olması gerekiyor.


            //var kosul2 = true;
            //var sounc6 = kosul ?        //iç içe kullanabiliyoruz gfakat clean code için çok tavsiye edilmiyor.
            //    kosul2 ? 34 : 23 
            //    : 45;

            //string ad = null;
            //string gercekAd = ad is null ? "Ad girilmemiş" : ad; 
            //gercekAd = ad ?? "Ad girilmemiş"; 


            //gercekAd = ad ??= "Ad girilmemiş";      //hem gercekAd değişkenine hemde ad değişkenine atanır. ad null atanmamış olur.

            #endregion


            #region if , else if , else
            //var sinavNotu = 78;
            //var gecmeNotu = 90;

            //var iseAlinacakMi = sinavNotu >= gecmeNotu;

            //if (iseAlinacakMi)
            //{
            //    Console.WriteLine("İşe alındınız.");
            //}

            //if (sinavNotu >= gecmeNotu)
            //{
            //    Console.WriteLine("İşe alındınız.");
            //}
            //if (iseAlinacakMi)
            //    Console.WriteLine("İşe alındınız.");

            //iseAlinacakMi = false;
            //if (iseAlinacakMi)
            //{
            //    Console.WriteLine("İşe alındınız. Pazartesi başlayınız");
            //}
            //else
            //{
            //    Console.WriteLine("Biz size dönüş yapacağız.");
            //}

            //if (iseAlinacakMi)
            //    Console.WriteLine("İşe alındınız. Pazartesi başlayınız");
            //else
            //    Console.WriteLine("Biz size dönüş yapacağız.");

            //var deneyimiVarMi = true;
            //if (iseAlinacakMi)
            //{
            //    Console.WriteLine("İşe alındınız. Pazartesi başlayınız");
            //}
            //else if (deneyimiVarMi)
            //{
            //    Console.WriteLine("Biz size dönüş yapacağız.");
            //}
            //else
            //{
            //    Console.WriteLine("Kriterlerimize uymuyorsunuz.");
            //}

            //var etkinligeKatilacakMi = true;

            ////bunu yapma
            //if (etkinligeKatilacakMi)
            //{
            //    Console.WriteLine("İyi eğlenceler."); 
            //    Console.WriteLine("Etkinlik başlamak üzere hadii");
            //}
            //else
            //{
            //    Console.WriteLine("Sizi aramızda göremeyeceğimiz için üzgünüz.");
            //    Console.WriteLine("Etkinlik başlamak üzere");
            //}

            ////bunu yap.
            //if (etkinligeKatilacakMi)
            //    Console.WriteLine("İyi eğlenceler.");
            //else
            //    Console.WriteLine("Sizi aramızda göremeyeceğimiz için üzgünüz.");

            //Console.WriteLine("Etkinlik başlamak üzere");

            #endregion

            //kullanıcıdan değer almak için kullanılır.
            Console.Write("Adınızı giriniz : ");
            var ad = Console.ReadLine();

            //Console.Write("Soyadınızı giriniz : ");
            //var soyad = Console.ReadLine();

            //Console.Write("Yaşınızı giriniz : ");
            //var yas = Console.ReadLine();

            //var yas2 = int.Parse(yas);
            //if(yas2 < 18)
            //{
            //    Console.WriteLine("Büyü de gel");
            //}
            //else
            //{
            //    Console.WriteLine("Hoşgeldiniz.");
            //}

            switch (ad)
            {
                case "Sila":
                    {
                        Console.WriteLine("Deneme");
                        break;
                    }
                case "Metin":
                    {
                        Console.WriteLine("Deneme 22");
                        break;
                    }
                case "Ata":
                    {
                        Console.WriteLine("Hoş geldin.");
                        break;
                    }
            }

            switch (ad)
            {
                case "Sila":
                    {
                        Console.WriteLine("Deneme");
                        break;
                    }
                case "Metin":
                    {
                        Console.WriteLine("Deneme 22");
                        break;
                    }
                case "Ata":
                    {
                        Console.WriteLine("Hoş geldin.");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Bugün kapalıyız.");
                        break;
                    }
            }

            var sinif = 5;
            switch (sinif)
            {
                case 1:
                    {
                        Console.WriteLine("Hoşgeldin ilkokullu");
                        break;
                    }
                case 5: 
                    {
                        Console.WriteLine("Hoşgeldin ortaokullu");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Hoşgeldin orta okullu");
                        break;
                    }
                case 11:
                    {
                        Console.WriteLine("Hoşgeldin liseli");
                        break;
                    }
                default:
                    break;
            }

            //daha kullanışlı bir switch yapısı
            switch (sinif)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    {
                        Console.WriteLine("Hoşgeldin ilkokullu");
                        break;
                    }
                case 5:
                case 6:
                case 7:
                case 8:
                    {
                        Console.WriteLine("Hoşgeldin ortaokullu");
                        break;
                    }
                case 9:
                case 10:
                case 11:
                case 12:        //sıralamanın bir önemi yok
                    {
                        Console.WriteLine("Hoşgeldin liseli");
                        break;
                    }
                default:
                    break;
            }

            var indirimKodu = "ISUBU";
            decimal sepetTutari = 1000;

            switch (sepetTutari)
            {
                case 1000 when (indirimKodu == "ISUBU"):        //koşul eklemek için when kullanıyoruz.
                    {
                        sepetTutari = sepetTutari * 0.9M;
                        break;
                    }
                case 2000 when (indirimKodu == "ISUBUPR"):
                    {
                        sepetTutari = sepetTutari * 0.8M;
                        break;
                    }
            }
            Console.WriteLine("Ödenecek tutar: " + sepetTutari);

            int sayi = 2;
            switch (sayi)
            {
                case 1:
                    {
                        Console.WriteLine("Test");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Deneme");
                        goto case 1;    //goto => case 1'e gönderiyor.
                    }
                    default:
                    break;
            }



            Console.WriteLine("Hello, World!");

        }
    }
}
