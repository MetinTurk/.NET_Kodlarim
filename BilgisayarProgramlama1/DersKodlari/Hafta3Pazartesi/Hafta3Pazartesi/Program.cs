using System.Numerics;

namespace Hafta3Pazartesi
{
    internal class Program
    {
        //string ad = "Sıla"; // global değişken
        static void Main(string[] args)
        {
            #region Saat 1 ve 2

            ////camelCase
            ////PascalCase
            ////snake_case    Snake_Case
            //Console.WriteLine("Hello, World!");

            //int yas = 90; //lokal (yerel) değişken
            //short not = 72;

            //int en = 5, boy = 24, yukseklik = 23;
            //int en1 , boy1 , yukseklik1 ;
            //Console.WriteLine(en);
            //Console.WriteLine(boy);
            //Console.WriteLine(yukseklik);
            //// cw -> code sniped

            //string name = "Sıla";
            //Console.WriteLine(name);

            //string tcKimlikNo = "123654658998";
            //string telefonNumarasi = "5556465231";

            //char karakter = 'S';

            //float sicaklik = 23.4f;
            //decimal maxSicaklik = 35.89M;

            //bool aktifMi = false;
            //// eski tuple kullanımı
            //Tuple<int, string, string> kisi = new Tuple<int, string, string>(1 , "Sila" , "Soyad");

            //Console.WriteLine(kisi.Item1);
            //Console.WriteLine(kisi.Item2);
            //Console.WriteLine(kisi.Item3);


            ////Yeni kullanım
            //(int Id, string Ad, string Soyad) hasta = (2, "Metin", "Soyad");
            //Console.WriteLine(hasta.Id);
            //Console.WriteLine(hasta.Ad);
            //Console.WriteLine(hasta.Soyad);

            //int x = 34;
            //Console.WriteLine(x);

            //int y = x;
            //Console.WriteLine(y);

            //const double PI = 3.14;
            //Console.WriteLine(PI);

            ////PI = 3;   //const olduğu için değerini değiştiremeyiz.

            ////const string test;    // değerini vermeden const yapamayız.

            //string test1; 
            #endregion

            #region Object
            ////Boxing / 
            //object ad = "Sila";
            //object yas = 23;
            //object engelliMi = false;
            //object boy = 1.55;

            //int yas2 = 15;
            //int yas3 = yas2 + 14;
            //Console.WriteLine(yas3);

            ////int sonuc = int(yas) - 5;     //hatalı

            //int yas4 = (int) yas;
            //Console.WriteLine(yas4 + 10);

            //string name = (string)ad;
            //bool isDisabled = (bool)engelliMi;
            //double lenght = (double)boy;

            ///*
            //object sayi = "Sila";
            //int sayi2 = (int)sayi;
            //Console.WriteLine(sayi2);
            //*/      //Hatalı

            ////object soyad = 4;
            ////string surname = (string)soyad;
            ////Console.WriteLine(surname);   //Hatalı 
            #endregion

            var sayi = 44;
            var ad = "Sila";
            var aktifMi = true;
            var sicaklik = 23.4;

            var sayi2 = sayi + 4;
            Console.WriteLine(sayi2);


            //runtime da bir data aldığımızda ve tipi belli değilse kullanılır.
            //runtime da tipini değiştirebilir.
            dynamic soyad = "Soyad";
            dynamic adres = "Isparta";
            dynamic nem = 65.67;
            dynamic vize = 90;
            Console.WriteLine(vize + 10);
            vize = "Final";


        }
    }
}
