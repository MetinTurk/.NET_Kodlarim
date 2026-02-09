using System.Globalization;

namespace Hafta4Pazartesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Parse
            //string sayi1 = "12";
            //var sonuc2 = sayi1 + 4;     //124 yaptı string toplama gerçekleştirdi (birleştirme operatörü)
            //int gercekSayi = int.Parse(sayi1);
            //var sonuc = gercekSayi + 4;

            //short gercekSayiShort = short.Parse(sayi1);
            //byte gercekSayiByte = byte.Parse(sayi1);

            //double gercekSayiDouble = double.Parse(sayi1);

            //string tarih = "06.10.2025";
            //DateTime datetime = DateTime.Parse(tarih);

            //string karakter = "A";
            //var gercekKarekter = char.Parse(karakter);

            //string sayi2 = "Sila";
            ////var gercekSayi2 = int.Parse(sayi2);   //Parse hata fırlatır yanlış tür dönüşümü

            //string aktifMi = "Evet";
            ////bool aktiflik = bool.Parse(aktifMi);  //Hatalı
            //aktifMi = "True";   
            //bool aktiflik = bool.Parse(aktifMi);  //Çevirme işlemi başarılı (true/True) or (false/False) kullanılabilir.


            //string sicaklik = "23.6";
            //double gercekSicaklik  = double.Parse(sicaklik);    //hatalı bir çevirme. (236)

            //sicaklik = "23,6";
            //gercekSicaklik = double.Parse(sicaklik);        //doğrusu bu şekilde

            //sicaklik = "23.6";
            //NumberFormatInfo formatInfo = new NumberFormatInfo();
            //formatInfo.NumberDecimalSeparator = ".";                //bu şekilde paremetre vererek de çevirebiliriz.
            //gercekSicaklik = double.Parse(sicaklik, formatInfo); 
            #endregion

            #region Convert
            //var sayi1 = 12;
            //int gercekSayi = Convert.ToInt32(sayi1);
            //short gercekSayiShort = Convert.ToInt16(sayi1);

            //var sicaklik = "24,3";
            //var gercekSicaklik = Convert.ToDouble(sicaklik);

            //var karakter = "S";
            //var gercekKarekter = Convert.ToChar(karakter);

            //int deger1 = 34;
            //var degerString = Convert.ToString(deger1);
            //var degerString2 = deger1.ToString();

            //double nem = 56.6;
            //var nemString = Convert.ToString(nem);

            //var sonuc = nem.ToString();


            //bool satisYapilacakMi = true;
            //sonuc = satisYapilacakMi.ToString();

            //string ad = "Sila";
            ////var adSayi = Convert.ToInt64(ad);

            //float sicaklikFloat = Convert.ToSingle(sicaklik);       //Float

            //bool test = false;      //Parse kullanılmaz , parse string'den döner.
            //sonuc = test.ToString();            //True
            //short sonuc2 = Convert.ToInt16(test);   //0
            //int sonuc3 = Convert.ToInt32(test);     //0

            //var test2 = Convert.ToBoolean(sonuc3);  //false
            //var test3= Convert.ToBoolean(0);        //false
            //var test4= Convert.ToBoolean(2);        //0 değilse hep true olur. (negatif pozitif farketmez)

            //var karakterInt = 80;
            //var karakter2 = Convert.ToChar(karakterInt);        // Büyük P harfini tanımladı. ASCII tabloya göre yapıyor.

            //karakter2 = 'ğ';
            //var ygKarekterKodu = Convert.ToInt32(karakter2);        //287 değerini aldı 
            #endregion


            #region Bilinçli / Bilinçsiz tür dönüşümü
            ////Bilinçli / Bilinçsiz tür dönüşümü

            //short sayiShort = 879;
            //int sayiInt = sayiShort;

            //long sayiLong = sayiShort;
            //sayiLong = sayiInt;


            //Bilinçli
            //32767
            //int sayi2 = 34;
            //short sayi2Short = sayi2;   //int bir değeri short'a atıyorsun. Dikkat et!
            //short sayi2Short = (short)sayi2;    //Sorumluluk sende bilinçli bir tür dönüşümü.

            //byte sayiByte = 255;
            //sbyte sayiByte2 = (sbyte)sayiByte;  //-1 değerini aldık data değişti.

            //checked         //data kaybı olduğunda hata fırlatır programı keser.
            //{
            //    byte sayiByte3 = 255;
            //    sbyte sayiByte22 = (sbyte)sayiByte;
            //}
            #endregion

            #region Aritmetik işlemler
            //int sonuc = 6 + 3;

            //int sonuc2 = sonuc + 89;
            //int sonuc3 = sonuc2 + sonuc;

            //int sayi = 9;
            //double sayi2 = 34.5;
            //double sonuc4 = sayi + sayi2;

            //var sonuc5 = sonuc2 - 34;
            //var sonuc6 = 89 - 78;
            //var sonuc7 = sonuc2 - sonuc6;

            //var sayi3 = 22;
            //var sayi4 = 5;
            //var sonuc8 = sayi3 * sayi4;

            //var sayi5 = 100;
            //var sayi6 = 21;
            //var sonuc9 = sayi5 / sayi6;     //iki tane int bölersek tam sayı elde ederiz.

            //sayi5 = 100;
            //var sayi7 = 21.0;
            //var sonuc10 = sayi5 / sayi7;

            //sayi5 = 100;
            //sayi6 = 21;
            //var sonuc11 = sayi5 / (double)sayi6;

            //var sonuc12 = sayi5 % 5;
            //sonuc12 = sayi5 % 3;
            //sonuc12 = sayi5 % 7;

            //var deger = 45;
            //deger = deger + 1;
            //deger++;
            //++deger;
            //Console.WriteLine(deger++);     //önce ekrana yazar sonra arttırır.
            //Console.WriteLine(++deger);     //önce değerini arttırır sonra ekrana yazar.

            //deger = deger - 1;
            //deger--;
            //--deger;
            //Console.WriteLine(deger--);
            //Console.WriteLine(--deger);

            //deger = deger + 5;
            //deger += 5;

            //deger = deger - 5;
            //deger -= 5;

            //deger = deger * 5;
            //deger *= 5;

            //deger = deger / 5;
            //deger /= 5;

            //deger = deger % 2;
            //deger %= 2;

            ////string birleştirme
            //string ad = "Sila";
            //string soyad = "Türk";

            //string fullName = ad + " " + soyad;

            //fullName += " Hoşgeldiniz."; 
            #endregion

            var sayi1 = 45;
            var sayi2 = 45;

            var sonuc = sayi1 == sayi2; //True
            var sonuc2 = sayi1 != sayi2;

            var ogrenci1 = "Sila";
            var ogrenci2 = "Sila";

            var isimlerAyniMi = ogrenci1 == ogrenci2;
            var isimlerFarkliMi = ogrenci1 != ogrenci2;

            var sicaklik = 22.5;
            var minimumsSicaklik  = 21;
            var minimumdanDusukMu = sicaklik < minimumsSicaklik;
            var minimumdanDusukEsitMu = sicaklik <= minimumsSicaklik;

            var maxSicaklik = 25;
            var maximumdanBuyukMu = sicaklik > maxSicaklik;
            var maximumdanBuyukEsitMi = sicaklik >= maxSicaklik;

            var bakiye = 55;
            var sepetTutari = 45;
            var yeterliBakiyeVarMi = bakiye >= sepetTutari;

            var cinsiyet = "Kadın";
            bakiye = 100;
            var seansGirisUcreti = 120;
            var okutulanTurnikeCinsiyet = "Erkek";

            var cinsiyetUyumluMu = okutulanTurnikeCinsiyet == cinsiyet;
            yeterliBakiyeVarMi = bakiye >= seansGirisUcreti;

            var iceriyeGirebilirMi = cinsiyetUyumluMu && yeterliBakiyeVarMi; 

            Console.WriteLine("Hello, World!");
        }
    }
}
