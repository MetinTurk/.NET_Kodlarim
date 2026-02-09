using System.Diagnostics;
using System.Runtime;

namespace Hafta6Pazartesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region switch
            //int toplamTutar = 1000;
            //int indirimOrani = 0;

            //switch (toplamTutar)
            //{
            //    case 1000: 
            //        indirimOrani = 10;
            //        break;
            //    case 2000: 
            //        indirimOrani = 20;
            //        break;
            //    case 3000: 
            //        indirimOrani= 35;
            //        break;
            //    default:
            //        indirimOrani = 0;
            //        break;
            //}
            //indirimOrani = 0;

            ////bu daha kullanışlı bir yazım.
            //indirimOrani = toplamTutar switch
            //{
            //    1000 => 10,
            //    2000 => 20,
            //    3000 => 35,
            //    _    => 0
            //};

            ////belli bir değer aralığı belirlemek istersek böyle kullanılır
            //indirimOrani = 0;
            //indirimOrani = toplamTutar switch
            //{
            //    var t when t >= 1000 && t < 2000 => 10,
            //    var t when t >= 2000 && t < 3000 => 20,
            //    var t when t >= 3000  => 35,
            //    _ => 0
            //};

            //int sayi1 = 20;
            //int sayi2 = 30;
            //string sonuc = "";

            //switch (sayi1 , sayi2)
            //{
            //    case (10,20):
            //        sonuc = "10 ve 20 değerleri girilmiş";
            //        break;
            //    case (20, 20):
            //        sonuc = "20 ve 20 değerleri girilmiş";
            //        break;
            //    case (20, 30):
            //        sonuc = "20 ve 30 değerleri girilmiş";
            //        break;
            //    default:
            //        break;
            //}

            //sonuc = (sayi1, sayi2) switch
            //{
            //    (10, 20) => sonuc = "10 ve 20 değerleri girilmiş",
            //    (20, 20) => sonuc = "20 ve 20 değerleri girilmiş",
            //    (20, 30) => sonuc = "20 ve 30 değerleri girilmiş",
            //    _ => "Koşullara uymadı"
            //};

            //var islem = "topla";
            //var islemSonucu = (sayi1, sayi2) switch
            //{
            //    (10, 20) when islem == "topla" => 10+20,
            //    (10, 20) when islem == "carp" => 10*20,
            //    (20, 20) when islem == "topla" => 40,
            //    (20, 30) when islem == "topla" => 20 * 30,
            //    _ => 0
            //};

            //var sayi3 = 123;
            //string sonuc3 = sayi3 switch
            //{
            //    < 100 => "Sayı 100 den küçük",
            //    > 100 => "Sayi 100 den büyük",
            //    _ => "Sayi değeri 100"
            //};

            //string sonuc4 = sayi3 switch
            //{
            //    < 100 => "Sayı 100 den küçük",
            //    >= 100 and <150 => "Sayi 100 den büyük 100'den küçük",
            //    >= 150 and <200 => "Sayi 150 den büyük 200'den küçük",
            //    >= 200 and <300 => "Sayi 200 den büyük 300'den küçük",
            //    _ => "Sayi değeri 100"
            //};

            //object sayi4 = 23;
            //if(sayi4 is int)
            //{
            //    int sayi5 = (int)sayi4;
            //    sayi5++;
            //}

            //object sayi6 = "22";
            //if(sayi6 is string)
            //{
            //    int sayi7 = int.Parse((string)sayi6);
            //    sayi7++;
            //}

            //if (sayi4 is int sayi8)//eğer true ise yazdığımız değişkene değerini ata.
            //{
            //    sayi8++;
            //}

            //if (sayi6 is string)
            //{
            //    int sayi7 = int.Parse((string)sayi6);
            //    sayi7++;
            //} 
            #endregion


            #region for while do while

            /*
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i+1}.Merhaba Dünya");
            }
            */

            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i+1);
            }
            */

            //ConditionalBreakPoint  == bellirli bir değerde durmak istediğimizde kullanılır
            //Örneğin: i 98 olduğunda durdur dediğimizde
            /*
            for (int i = 0; i <= 100; i+=2)
            {
                Console.WriteLine(i);
                
            }
            */
            /*
            for (int i = 10; i > 0; i-=3)
            {
                Console.WriteLine("Merhaba "+ i);
            }
            */
            /*
            //Sonsuz döngü.
            for( ; ; )
            {
                Console.WriteLine("Deneme");
            }
            */

            /*
            int sayi = 0;
            //bu şekilde bir kullanım vardır fakat tavsiye edilmez.
            for (; sayi < 90; )
            {
                Console.WriteLine(sayi);
                sayi++;
            }

            for(;sayi < 90; sayi++)
            {
                Console.WriteLine(sayi);
            }
            */

            /*
            //böyle bir kullanım var fakat tavsiye edilmez.
            for (int i = 0; i < 10; i++, Console.Write("Hadi"))
            {
                Console.WriteLine(" Bakalım");
            }
            */

            //int toplam = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    toplam += i;
            //}
            //Console.WriteLine("Toplam: " + toplam);

            //int carpim = 1;
            //for (int i = 2; i <= 10; i++)
            //{
            //    carpim *= i;
            //}
            //Console.WriteLine("Çarpim: " + carpim);



            //Console.Write("Max sayıyı girin: ");
            //var girilenDeger = Console.ReadLine();
            //var deger = Convert.ToInt32(girilenDeger);
            //var toplam = 0;
            //for (int i = 1; i <= deger; i++)
            //{
            //    toplam += i;   
            //}
            //Console.WriteLine("Toplam "+ toplam);


            //int sayi2 = 0;

            //while(sayi2<10)
            //{
            //    sayi2++;
            //}

            //Console.Write("Bir karakter girin: ");
            //var girilen = Console.ReadLine();
            //while (girilen != "S")
            //{

            //}


            //////Sonsuz döngü
            ////while (true)
            ////{

            ////}
            //string girilen2 = "";
            //do
            //{
            //    Console.Write("Bir karakter girin: ");
            //    girilen2 = Console.ReadLine();

            //    Console.WriteLine(girilen);
            //}
            //while (girilen != "S");

            #endregion

            #region iç içe döngüler
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.WriteLine(i + " " + j);
            //    }
            //}

            //int sayi2 = 89;
            //while (sayi2 > 2)
            //{
            //    for (int i = 0; i < 4; i++)
            //    {
            //        Console.WriteLine("Test");
            //    }
            //    sayi2 -= 5;
            //} 
            #endregion

            //for (int i = 0; i < 100; i++)
            //{
            //    if(i == 10)
            //    {
            //        continue;       //altında yazılan kodların hiçbirini çalıştırmaz başa dönmeni sağlar.
            //    }
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i <= 100; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        break;              //döngüyü kırar.
            //    }
            //    Console.WriteLine(i);
            //}

            //int sayi3 = 88;
            //while (true)
            //{
            //    if(sayi3 < 50)
            //    {
            //        break;
            //    }
            //    sayi3 -= 10;
            //}


            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        if(i == 2)
            //        {
            //            break;
            //        }

            //        if(j == 1)
            //        {
            //            break;
            //        }
            //        Console.WriteLine(i + " " + j);
            //    }
            //    if(i == 3)
            //    {
            //        break;
            //    }
            //}





            Console.WriteLine("Hello, World!");

        }
    }

}
