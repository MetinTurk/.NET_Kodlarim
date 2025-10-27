using System.Net.Http.Headers;
using System.Text;
using System.Threading.Channels;

namespace Hafta7Pazartesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tek Boyutlu dizi
            //int yas = 78;

            //int[] yaslar = new int[10];
            //string[] adlar = new string[10];
            //double[] sicakliklar = new double[10];
            //decimal[] bakiyeler = new decimal[10];
            //bool[] aktiflik = new bool[10];         //hrpsinin default değeri atanır.

            //string[] ogrenciler = new string[5] { //bütün dizinin ilk değerlerini vermemiz gerekir. 
            //    "Sila",
            //    "Metin",
            //    "Ata",
            //    "Ülkü",
            //    "Semih"
            //};

            //string[] ogrenciler2 = { // new string[5] gerek yok c# anlıyor bunu yapacağımızı.
            //    "Sila",
            //    "Metin",
            //    "Ata",
            //    "Ülkü",
            //    "Semih"
            //};

            //bool[] engelDurumlari =
            //{
            //    true,
            //    false,
            //    false
            //};

            //var nemler = new[] {23 ,23 , 45 ,56};
            ////var nemler2 = new { 23, 23, 45, 56 };     // bu kullanım doğru değil dizi olduğunu belirtmemiz gerekiyor.


            //var yaslar2 = new double[15];
            //var ilkNemDatasi = nemler[0];
            //var sonNemDatasi = nemler[3];

            ////var sonNemDatasi2 = nemler[4];        //dizi boyutunu aştın

            //nemler[0] = 32; //dizinin istediğimiz indisindeki değeri değiştirme. 


            //string[] yeniOgrenciler = {
            //    "Sila",
            //    "Metin",
            //    "Ata",
            //    "Ülkü",
            //    "Semih",
            //    "Betül"
            //};

            //Console.WriteLine(yeniOgrenciler[0]);
            //Console.WriteLine(yeniOgrenciler[1]);
            //Console.WriteLine(yeniOgrenciler[2]);
            //Console.WriteLine(yeniOgrenciler[3]);
            //Console.WriteLine(yeniOgrenciler[4]);

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(yeniOgrenciler[i]);
            //}

            //for (int i = 0; i < yeniOgrenciler.Length; i++)
            //{
            //    Console.WriteLine(yeniOgrenciler[i]);
            //}

            //string[] uyeler = new string[10];
            //for (int i = 0; i < uyeler.Length; i++)
            //{
            //    Console.Write($"{i+1}. Üyenin adı: ");
            //    uyeler[i] = Console.ReadLine();
            //}
            //Console.WriteLine("Teşekkürler giriş için.");
            //Console.WriteLine("Üye listesi: ");
            //for (int i = 0; i < uyeler.Length; i++)
            //{
            //    Console.WriteLine(i+1 + ". üyenin adı: " + uyeler[i]);
            //}

            //Array.Clear(yeniOgrenciler);        //dizinin bütün datalarını default değerine döndürdü (temizledi)

            //int[] yaslar = { 3 , 6 , 99 , 23 , 67 , 3 };
            //Array.Clear(yaslar, 1 , 2);         //dizinin temizlenmesi için başlangıç değeri ve kaç adet temizleneceğini verdik.

            //int[] yaslar2 = new int[yaslar.Length]; //önceki dizinin boyutu kadar boyutu olsun.
            //Array.Copy(yaslar, yaslar2 , yaslar.Length);    //ilk paremetre : kopyalanması gereken dizi, ikinci paremetre: kopyalanacak yer, üçüncü paremetre: uzunluğu

            //int deneme1 = 12;
            //int deneme2 = deneme1;

            ////diziler referans tipli olduğu için bu şekilde atama yaptığımızda aynı adresi göstericekleri için yapılan değişiklik ikisinde de değiştirilir.
            //var yaslar3 = yaslar;

            //yaslar3[1] = 34;

            ////bir dizide object araması yapmak istiyorsak bu şekilde kullanabiliriz.
            //// IndexOf = eğer bulursa index, bulamazsa -1 değeri döndürür
            //var yas18Index = Array.IndexOf(yaslar, 18);
            //var yas23Index = Array.IndexOf(yaslar, 23);
            //if(yas23Index != -1)
            //{
            //    yaslar[yas23Index] = 24;
            //}
            ////yaslar[yas23Index] = 24; // bu şekilde direkt kullanma hata çıkma ihtimali yüksek, önce kontrol et sonra kullan

            //var yas3Index = Array.IndexOf(yaslar, 3);   //eğer bir dizide birden fazla aramak istediğimiz veri varsa ilk bulduğu değeri döndürür.
            //yas3Index = Array.IndexOf(yaslar, 3, 1);    // 3. paremertre: başlangıç indeksini veriyor.

            //Array.Reverse(yaslar2); //diziyi tersine çevirir.
            //Array.Sort(yaslar2);    //küçükten büyüğe sıralar.

            //var notlar = new int[] { 89 , 99 , 90 ,75 };
            //Array.Sort (notlar);
            //Array.Reverse(notlar); 
            #endregion

            #region Çok boyutlu diziler ve düzensiz diziler
            //int[,] goruntu = new int[3 , 5];    //iki boyutlu dizi

            //var ilkVeri = goruntu[0 , 0];
            //goruntu[1, 2] = 89;
            //goruntu[2, 1] = 89;
            //goruntu[0, 4] = 89;

            //int[,] goruntu2 =
            //{
            //    {5,4,8,9},
            //    { 15,40,18,19 },
            //    { 3,4,18,19 }
            //};

            ////for (int i = 0; i < 3; i++)
            ////{
            ////    for (int j = 0; j < 4; j++)
            ////    {
            ////        Console.Write(goruntu2[i, j] + " ");
            ////    }
            ////    Console.WriteLine();
            ////}

            //var kacBoyutlu = goruntu.Rank;  //kaç boyutlu olduğunu döndürür (2)
            //int[] yaslar = new int[3];
            //var yaslarKacBoyutlu = yaslar.Rank; //(1)

            //for (int i = 0; i < goruntu2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < goruntu2.GetLength(1); j++)
            //    {
            //        Console.Write(goruntu2[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //string[,,] ucBoyutluDizi = new string[2,4,3];

            ////Düzensiz diziler

            //int[][] veriler = new int[3][];
            //veriler[0] = new int[4];
            //veriler[1] = new int[2];
            //veriler[2] = new int[10];

            //veriler[0][2] = 89;     //düzensiz dizilerde değer ataması bu şekilde yapılır.
            //veriler[1][0] = 44;
            //veriler[2][5] = 90;

            //for (int i = 0; i < veriler.Length; i++)
            //{
            //    for (int j = 0; j < veriler[i].Length; j++)
            //    {
            //        Console.WriteLine(veriler[i][j]);
            //    }
            //} 
            #endregion


            #region String
            //string ad = "";         //ramde tutulacağı adres belli
            //string ad2 = String.Empty;         //ramde tutulacağı adres belli üst satırla aynı
            //string soyad = null;    //ramde tutulacağı adres belli değil
            //var adres = "Isparta";

            //var adIsNullOrEmptyMi = string.IsNullOrEmpty(ad);       //true
            //var ad3IsNullOrEmptyMi = string.IsNullOrEmpty(ad2);     //true
            //var soyadIsNullOrEmptyMi = string.IsNullOrEmpty(soyad); //true  
            //var adresIsNullOrEmptyMi = string.IsNullOrEmpty(adres); //false

            //var cinsiyet = " ";
            //var cinsiyetIsNullOrEmptyMi = string.IsNullOrEmpty(cinsiyet); //false
            //var cinsiyetIsNullOrWhiteSpaceMi = string.IsNullOrWhiteSpace(cinsiyet); //true  //null mı veya sadece boşluktan mı oluşuyor

            //char karakter1 = adres[0];      //String ifadeyi char'a döndürürüz
            //char karakter2 = adres[1];

            //char[] adresKarakterleri = adres.ToCharArray();

            //ad = "Kobe";
            //soyad = "BRYANT";
            //var message = "The moment you give up is the moment you let someone else win ";
            //var yil = 2015;

            //var tamAd = ad + " " + soyad;

            //var tumMesaj = ad + " " + soyad + " " + yil + " yılında " + message + " demiştir.";

            //var tumMesaj2 = string.Format("{0} {1} {2} yılında {3} demiştir", ad, soyad, yil, message);     //Format kullanımı

            //var tumMesaj3 = $"{ad} {soyad} {yil} yılında {message} demiştir.";      //Daha kullanışlı.

            //var sb = new StringBuilder();
            //sb.Append(ad);
            //sb.Append(" ");
            //sb.Append(soyad);
            //sb.Append(" ");
            //sb.Append(yil);
            //sb.Append( " yılında ");
            //sb.Append(message);
            //sb.Append( " demiştir.");
            //var tumMesaj4 = sb.ToString();   
            #endregion

            var mesaj = "Ne kadar bilirsen ey dost bilene danış";

            // ne ile başlıyor (bool döndürür)
            var sonuc = mesaj.StartsWith("N");
            sonuc = mesaj.StartsWith("Ne");
            sonuc = mesaj.StartsWith("Sila");
            sonuc = mesaj.StartsWith("A");
            sonuc = mesaj.StartsWith("ne");

            //ne ile bitiyor (bool döndürür)
            sonuc = mesaj.EndsWith("ş");        //true
            sonuc = mesaj.EndsWith("nış");      //true
            sonuc = mesaj.EndsWith("Ali");      //false
            sonuc = mesaj.EndsWith("Ş");        //false


            //içeriyor mu (içerisinde var mı) , (bool döndürür)
            sonuc = mesaj.Contains("ey");        //true
            sonuc = mesaj.Contains("dost");      //true
            sonuc = mesaj.Contains("Ali");       //false
            sonuc = mesaj.Contains("Ş");         //false    

            var sonuc2 = mesaj == "Ne kadar bilirsen ey dost bilene danış";
            sonuc2 = mesaj.Equals("Ne kadar bilirsen ey dost bilene danış");

            var sIndex = mesaj.IndexOf("s");
            var eyIndex = mesaj.IndexOf("ey");

            var yeniMesaj = mesaj.Remove(eyIndex, 3);
            yeniMesaj = mesaj.Remove(0, 3);
            yeniMesaj = mesaj.Remove(6);

            yeniMesaj = mesaj.Replace("dost", "arkadaş");
            yeniMesaj = mesaj.Replace("d", "D");
            yeniMesaj = mesaj.Replace(" ", "");     //bulduğu bütün oldCharları newChar'a çevirir (replace parametre isimlendirmesi)

            var kelimeler = mesaj.Split(" ");       //boşluklardan ayırarak yeni diziye ekler ve geriye dizi döndürür.
            kelimeler = mesaj.Split("ey");

            var veri = "23;45;12;SER;asdas";
            var veriler = veri.Split(";");


            var sonuc3 = mesaj.Substring(0, 3);     //stringin belirli bölümünü alırız.
            sonuc3 = mesaj.Substring(0, 10);        //parametreler: başlangıç ve bitiş değerleri
            sonuc3 = mesaj.Substring(18, 5);
            sonuc3 = mesaj.Substring(18);
            sonuc3 = mesaj.Substring(18, 1);        //string olarak aldık char olarak değil

            var soyad = "Baş";
            soyad = soyad.ToUpper();                //Hepsini büyük harfe çevirir.
            soyad = soyad.ToLower();                //Hepsini küçük harfe çevirir.

            soyad = "               Baş            ";
            var yeniSoyad = soyad.TrimStart();      //Sadece başlangıçdaki boşlukları siler.
            yeniSoyad = soyad.TrimEnd();            //Sadece sondaki boşlukları siler.
            yeniSoyad = soyad.Trim();               //Hem baştan hemde sondaki boşlukları siler.

            int gun = 1;
            int ay = 10;
            int yil = 2025;

            string tarih = $"{gun.ToString().PadLeft(2,'0')}.{ay}.{yil}";   //PadLeft(2,'0') : Sol tarafta 2 karakter yer ayır, eğer değer yoksa verdiğimiz parametreyi gir.

            gun = 12;
            tarih = $"{gun.ToString().PadLeft(2, '0')}.{ay.ToString().PadRight(2, '0')}.{yil}";

            Console.WriteLine("Hello, World!");
        }
    }
}
