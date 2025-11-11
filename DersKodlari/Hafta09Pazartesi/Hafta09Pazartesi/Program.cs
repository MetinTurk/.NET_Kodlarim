using Microsoft.Win32.SafeHandles;

namespace Hafta09Pazartesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Math


            //var sonuc = Math.Abs(-3);       //Mutlak değer
            //sonuc = Math.Abs(5);

            //var sonuc2 = Math.Ceiling(12.3);        //+sonsuza doğru en yakın tam sayıya yuvarlar.
            //sonuc2 = Math.Ceiling(12.7);    //13
            //sonuc2 = Math.Ceiling(-12.7);   //-12
            //sonuc2 = Math.Ceiling(-12.2);   //-12


            //sonuc2 = Math.Floor(12.3);        //-sonsuza doğru en yakın tam sayıya yuvarlar.
            //sonuc2 = Math.Floor(12.7);    //12
            //sonuc2 = Math.Floor(-12.7);   //-13
            //sonuc2 = Math.Floor(-12.2);   //-13


            //sonuc2 = Math.Round(12.3);        //en yakın çift tam sayıya yuvarlar.
            //sonuc2 = Math.Round(12.7);    //13
            //sonuc2 = Math.Round(-12.7);   //-13
            //sonuc2 = Math.Round(-12.2);   //-12
            //sonuc2 = Math.Round(11.5);    //12
            //sonuc2 = Math.Round(12.5);    //12
            //sonuc2 = Math.Round(12.5,MidpointRounding.AwayFromZero);    //13    //Sıfırdan uzağa yuvarla.
            //sonuc2 = Math.Round(-12.5);    //-12
            //sonuc2 = Math.Round(-12.5,MidpointRounding.AwayFromZero);    //-13
            //var sonuc4 = Math.Round(12.33654651531, 2); //virgülden sonra 2 basamak gösterir.
            //sonuc4 = Math.Round(12.33656548689, 3);


            //sonuc2 = Math.Truncate(12.3);       //ondalıklı sayının tam kısmını alır
            //sonuc2 = Math.Truncate(12.7);
            //sonuc2 = Math.Truncate(-12.7);
            //sonuc2 = Math.Truncate(-12.3);

            //var sonuc3 = Math.Pow(2, 5);        //ilk parametre taban ikinci üs
            //sonuc3 = Math.Sqrt(25);             //karekök alır
            //sonuc3 = Math.Log10(100);           //log 10 tabanında hesap yapar
            //sonuc3 = Math.Log2(128);            //log 2 tabanında hesap yapar
            //sonuc3 = Math.Exp(5);               //e üzeri 5 yapar.

            //sonuc3 = Math.Log(Math.Exp(5));     //ln tabanında işlem yapar
            //sonuc3 = Math.Log(Math.Pow(Math.E,5));     //ln tabanında işlem yapar yukarıdaki ile aynı işlem
            ////sonuc3 = Math.PI      //PI

            //var minDeger = Math.Min(12, 45);
            //var maxDeger = Math.Max(12, 45);

            //var degisken = 25;
            //if (degisken < 0)
            //    degisken = 0;
            //degisken = Math.Max(0, degisken);

            //var vizeNotu = 78;
            //if (vizeNotu > 100)
            //    vizeNotu = 100;
            //vizeNotu = Math.Min(100, vizeNotu);

            //var sin90 = Math.Sin(Math.PI / 2);
            //var sin30 = Math.Sin(Math.PI / 6);

            //var cos90 = Math.Cos(Math.PI / 2);
            //var cos30 = Math.Cos(Math.PI / 6);

            //var sonuc5 = Math.Sign(12);
            //sonuc5 = Math.Sign(-12); 
            #endregion



            //Random rnd = new Random();
            //var rastgeleSayi = rnd.Next(0 , 100);       //başlangıç değeri , bitiş değeri : arasında değer alır
            //rastgeleSayi = rnd.Next(0 , 100);
            //rastgeleSayi = rnd.Next(50 , 100);

            //var rastgeleDouble = rnd.NextDouble();      //0 ile 1 arasında bir ondalıklı sayı tutmak istediğimizde kullanırız

            //var tutulanSayi = Random.Shared.Next(0, 100);
            //do
            //{
            //    Console.WriteLine("Tahmininizi girin: ");
            //    var deger = int.Parse(Console.ReadLine());
            //    if(deger == tutulanSayi)
            //    {
            //        Console.WriteLine("Tebrikler Sayıyı buldunuz");
            //        break;
            //    }
            //    else if(deger < tutulanSayi)
            //    {
            //        Console.WriteLine("Sayıyı büyültün");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sayıyı küçültün");
            //    }
            //}
            //while (true);


            #region DateTime
            //var tarih = new DateTime(2025, 11, 10);
            //var tarihveSaat = new DateTime(2025, 11, 10, 9, 45, 15);
            //tarihveSaat = DateTime.Parse("10.11.2025");

            //var suan = DateTime.Now;
            //var bugun = DateTime.Today;

            //var suanUTC = DateTime.UtcNow;

            //var gun = bugun.DayOfWeek;
            //var dogumTarihi = new DateTime(2003, 4, 26, 9, 45, 15);

            //switch (dogumTarihi.DayOfWeek)
            //{
            //    case DayOfWeek.Sunday:
            //        break;
            //    case DayOfWeek.Monday:
            //        break;
            //    case DayOfWeek.Tuesday:
            //        break;
            //    case DayOfWeek.Wednesday:
            //        break;
            //    case DayOfWeek.Thursday:
            //        break;
            //    case DayOfWeek.Friday:
            //        break;
            //    case DayOfWeek.Saturday:
            //        break;
            //    default:
            //        break;
            //}

            //var onGunSonra = bugun.AddDays(10);
            //var sonuc = bugun.AddMonths(3);
            //sonuc = bugun.AddYears(3);

            //var onBesGunOnce = bugun.AddDays(-15);
            //sonuc = bugun.AddMonths(-3);
            //sonuc = bugun.AddYears(-3);

            //sonuc = suan.AddHours(3);
            //sonuc = suan.AddMinutes(30);
            //sonuc = suan.AddSeconds(30);

            //var kalan = bugun.Subtract(dogumTarihi);    //bugün - dogum tarihi yapar.

            //sonuc = suan.Add(new TimeSpan(2, 30, 15));

            //var kacGun = DateTime.DaysInMonth(2025, 2);
            //kacGun = DateTime.DaysInMonth(2020, 2);
            //kacGun = DateTime.DaysInMonth(2025, 6); 
            #endregion

            Test();
            Yaz();

            Yaz();

            Yazdir(40);
            Topla(12, 15);

            Topla(40, 200);
            Topla2(22);

            Topla3(22, "işlem sonucu");
            Topla3(22, "işlem sonucu", 45);
            Topla3(22, "işlem sonucu", 45, true);
            Topla3(22, "işlem sonucu", aktiflik: false);    //eğer sayi2 değerini vermek istemiyorsak

            Topla(sayi2: 89, sayi1: 22);    //sıralamayı öenmsiz kılmak için bu şekilde yazabiliriz.

            var mesaj = GetMessage();

            var maas = MaasHesapla(10, 20000, 10);


            var sayi = 44;
            Degistir(sayi);
            Console.WriteLine("Sayi: " + sayi);

            int[] yaslar = new[] { 1, 5, 7 };
            DegistirDizi(yaslar);
            for (int i = 0; i < yaslar.Length; i++)
            {
                Console.WriteLine(yaslar[i]);
            }

            Degistir2(ref sayi);        //referansını (adresini) gönderdik, değeri değişti.

            Degistir3(out sayi);        //


            int sayi2;

            //Degistir2(ref sayi2);       //değişkenin değeri olmadığı için adresi belli değil bu yüzden adresini gönderemiyoruz. (ref kullanabilmek için değer ataması yapmamız gerekir.)
            Degistir3(out sayi2);         // adresinin belli olmaması önemli değil

            if(int.TryParse("23" , out int sayi4))
            {
                sayi4++;
                Console.WriteLine(sayi4);
            }

            if (int.TryParse("sila", out int sayi5))
            {
                sayi4++;
                Console.WriteLine(sayi5);
            }
            else
            {
                Console.WriteLine("Girilen deger int dönüstürülemiyor.");
            }









                Console.WriteLine("Hello, World!");
        }

        //DRY
        static public void Test()
        {
            Console.WriteLine("Test");
        }

        static void Yaz()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(i+1);
            }
        }

        static void Yazdir(int sayi)
        {
            for (int i = 0; i < sayi; i++)
            {
                Console.WriteLine(i + 1);
            }
        }

        static void Topla(int sayi1 , int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }

        static string GetMessage()
        {
            return "Merhaba";
        }

        static int Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }

        static decimal MaasHesapla(decimal kacYilCalisti , decimal tabanMaas , int primYuzdesi)
        {
            return (kacYilCalisti * 1000 + tabanMaas) * (1 + ((decimal)primYuzdesi / 100.0M));
        }

        static void Topla2(int sayi1 , int sayi2 = 90)      //sayi2 = default tanımlı kullanmayabiliriz
        {
            Console.WriteLine(sayi1+sayi2);
        }

        //static void Topla2(int sayi1, int sayi2 = 90 , string message)      //default tanımlı degisken en sonra olmak zorunda
        //{
        //    Console.WriteLine(sayi1 + sayi2);
        //}

        static void Topla3(int sayi1, string message, int sayi2 = 90 , bool aktiflik = true)      //default tanımlı degisken en sonra olmak zorunda
        {
            if (aktiflik)
            {

            }
            else
            {

            }
                Console.WriteLine(sayi1 + sayi2);
        }

        static void Degistir(int sayi)
        {
            sayi = 90;      //farklı scopelarda oldukları için değeri değişmedi (değer tipli)
        }

        static void DegistirDizi(int[] input)
        {
            input[0] = 90;      //dizinin referansı ile geldiği için değeri değiştirebildik. (referans tipli)
            input[1] = 40;
        }

        static void Degistir2(ref int sayi)     //ref = gelen paremetrenin referansını alır
        {
            sayi = 80;
        }

        static void Degistir3(out int sayi)     //out = gelen paremetrenin referansını alır (değeri atanıp atanmadığına bakılmaz.)
        {
            sayi = 180;
        }

        static void MaasHesapla2(in int katSayi)        //in = sabitmiş gibi davranır. (const)
        {
            //katSayi = 9000;
            var hesapSonucu = katSayi * 89;
        }
    }
}
