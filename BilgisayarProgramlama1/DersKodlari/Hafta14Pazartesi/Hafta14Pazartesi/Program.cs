using System.Text;

namespace Hafta14Pazartesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            ////Dosyalama işlemlerinde kullanırım.
            //var denemeKlasoruVarMi = Directory.Exists("Deneme");
            //if (!denemeKlasoruVarMi)
            //{
            //    Directory.CreateDirectory("Deneme");
            //}
            //else
            //{
            //    Directory.Delete("Deneme");
            //}

            //var destinationPath = Path.Combine("D:", "11");
            //Directory.Move("Deneme", "Deneme2");

            //var destinationPath2 = Path.Combine("C:", "Dersler","2025" , "");
            //var rastgeleDosya = Path.GetRandomFileName();
            //var dosyaAdi = "test.pdf";
            //var dosyaUzantisi = Path.GetExtension(dosyaAdi);
            //Directory.Move("Deneme2", "C:\\Users\\Metin23\\source\\repos\\BilgisayarProgramlama1\\DersKodlari\\Hafta14Pazartesi\\Hafta14Pazartesi\\bin\\Debug");



            ////geçici dosyaların konumunu verir
            //var tempPath = Path.GetTempPath();


            ////Bir klasorün içerisinde hangi klasörler var onu gösterir
            //var varOlanKlasorler = Directory.GetDirectories("Deneme");
            //foreach (var item in varOlanKlasorler)
            //{
            //    Console.WriteLine(item);
            //}

            //var varOlanDosyalar = Directory.GetFiles("Deneme");

            //foreach (var item in varOlanDosyalar)
            //{
            //    Console.WriteLine(item);
            //}

            //var denemePath = Path.Combine("Deneme", "merhaba.txt");
            //if(!File.Exists(denemePath))
            //{

            //}
            //else
            //{
            //    File.Delete(denemePath);
            //}
            //var sourcePath = Path.Combine("Deneme", "arşiv.zip");
            //var destinationPath = Path.Combine("Deneme","Metin" ,  "arşiv.zip");

            //File.Move(sourcePath, destinationPath);

            //var sourcePath2 = Path.Combine("Deneme", "Metin", "arşiv.zip");
            //var destinationPath2 =  Path.Combine("Deneme", "arşiv.zip");

            //File.Copy(sourcePath2, destinationPath2);


            string metin = "Sıla bugün okula gitti";

            File.WriteAllText("hikaye.txt", metin);


            var sb = new StringBuilder();
            sb.AppendLine("Deneme");
            for (int i = 0; i < 10; i++)
            {
                sb.Append(i);
            }
            File.WriteAllText("hikaye2.txt" , sb.ToString());


            var icerik = File.ReadAllText("hikaye2.txt");
            Console.WriteLine(icerik);

            var satirOlarakIcerik = File.ReadAllLines("hikaye2.txt");

            foreach (var adayBilgi in satirOlarakIcerik)
            {
                var ad = adayBilgi.Substring(0, 10).Trim();
                var adsoyad = adayBilgi.Substring(10, 10).Trim();
                var kitapcikTuru = adayBilgi.Substring(25, 1).Trim();
                var ogrenciNo = adayBilgi.Substring(26, 10).Trim();
                var ogrenciCevap = adayBilgi.Substring(39, 10);


            }

            List<string> ogrenciListesi = new List<string>() {
            "Elif", //hocanın kızının adı (kontrol edilebilir: OSİNT)
            "Sila",
            "Metin",
            "Arven"
            };

            File.WriteAllLines("deneme4.txt", ogrenciListesi);



            Console.WriteLine();

        }
    }
}
