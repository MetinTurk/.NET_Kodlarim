using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;

namespace VizeCalismaSorulari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[,] sicaklik_nem_matrisi =
            //{
            //    {22, 45, 21, 50}, // Bölge 1 verileri
            //    {25, 40, 26, 42}, // Bölge 2 verileri
            //    {20, 55, 19, 60}  // Bölge 3 verileri
            //};

            //Console.WriteLine($"Dizi: {sicaklik_nem_matrisi.Rank} boyutlu");
            //for (int i = 0; i < sicaklik_nem_matrisi.GetLength(0); i++)
            //{
            //    for (int j = 0; j < sicaklik_nem_matrisi.GetLength(1); j++)
            //    {
            //        Console.WriteLine(sicaklik_nem_matrisi[i,j]);
            //    }
            //}

            #region Mükemmel Soru
            //string HamTakipVerisi = "TR-KIMYASAL-NITRO-2024;  SE-RADYOAKTIF-PLUTON-2023 ;US-PATLAYICI-TUP-2025;TR-NORMAL-KUTU-2024;" +
            //    "US-PATLAYICI-Dinamit-2024; DE-kımyasal-ASIT-2025 ";

            //string[] paketKodlari = HamTakipVerisi.Split(';');

            //for (int i = 0; i < paketKodlari.Length; i++)
            //{
            //    paketKodlari[i]= paketKodlari[i].Trim();
            //    if (string.IsNullOrWhiteSpace(paketKodlari[i]))
            //    {
            //        continue;
            //    }
            //}

            //int sayac = 1;
            //for (int i = 0; i < paketKodlari.Length; i++)
            //{
            //    string[] temizPaketKodlari = paketKodlari[i].Split("-");
            //    temizPaketKodlari[1] = temizPaketKodlari[1].ToUpper();
            //    decimal ozelPaketUcreti = temizPaketKodlari[1] switch
            //    {
            //        "KIMYASAL" => 250.0M,
            //        "RADYOAKTIF" => 400.0M,
            //        "PATLAYICI" => 600.0M,
            //        "NORMAL" => 200.0M,
            //        _ => 0
            //    };
            //    Console.WriteLine($"Paket işleniyor: {paketKodlari[i]} -> Kategori: {temizPaketKodlari[1]}. Ücret: {ozelPaketUcreti}");

            //} 
            #endregion

            #region 2. Mükemmel Soru
            //string HamYazmaVerisi = "YAZAR_ALFA_TRAD001|   YAZAR_BETA_KRONOS002| YAZAR_TET A_ANALIZ103|YAZAR_OMEGA_SILAS104 |YAZAR_BETA_TRAD999";

            //string[] yazmaVerisi = HamYazmaVerisi.Split('|');

            //for(int i = 0; i < yazmaVerisi.Length; i++)
            //{
            //    yazmaVerisi[i] = yazmaVerisi[i].Trim();
            //    if (string.IsNullOrWhiteSpace(yazmaVerisi[i]))
            //    {
            //        continue;
            //    }
            //}

            //int toplam = 0;
            //for (int i = 0; i < yazmaVerisi.Length; i++)
            //{
            //    string[] temizYazmaVerisi = yazmaVerisi[i].Split("_");
            //    temizYazmaVerisi[1] = temizYazmaVerisi[1].ToUpper();
            //    string protokolNo = temizYazmaVerisi[2];

            //    int guvenPuani = (temizYazmaVerisi[1],protokolNo) switch
            //    {
            //        (var x, var y) when (x == "ALFA" || x == "BETA") && y.StartsWith("TRAD") => 50,
            //        (var x, var y) when (y.Contains("KRONOS") && x.IndexOf(" ") != 0 ) => 30,
            //        (var x, var y) when (x == "TETA") && (y.Substring(y.Length-3,3) == "103") => 10,
            //        _ => -10,
            //    };
            //    Console.WriteLine($"Paket işleniyor. {yazmaVerisi[i]} -> Güven puanı: {guvenPuani}");
            //    toplam += guvenPuani;
            //}
            //Console.WriteLine($"Toplam güven puanı: {toplam}"); 
            #endregion

            double bsmv = 0.1, kkdf = 0.15, faiz = 0.02, kredi = 10000;
            int ay = 4;

            double toplamFaizOrani = faiz * (bsmv + kkdf + 1);
            double aylikTaksitTutari = Math.Round((kredi * (toplamFaizOrani * Math.Pow(1 + toplamFaizOrani, ay))) / (Math.Pow(1 + toplamFaizOrani, ay) - 1), 2);

            Console.WriteLine("Ay \t Taksit \t Anapara \t Faiz \t \t BsmvTutar \t KkdfTutar \t KalanAnaPara ");
            double toplamFaiz = 0, toplamBsmvTutar = 0, toplamKkdfTutar = 0, kalanPara = kredi;
            for (int i = 0; i < ay; i++)
            {
                double uygulanacakFaiz = Math.Round(kalanPara * faiz, 2);
                double uygulanacakBsmv = Math.Round(uygulanacakFaiz * bsmv,2);
                double uygulanacakKkdf = Math.Round(uygulanacakFaiz * kkdf, 2);
                double aylikAnaPara = Math.Round(aylikTaksitTutari - (uygulanacakFaiz + uygulanacakBsmv + uygulanacakKkdf) ,2);
                kalanPara = Math.Round(kalanPara - aylikAnaPara, 2);
                Console.WriteLine($"0{i+1} \t {aylikTaksitTutari} \t {aylikAnaPara} \t {uygulanacakFaiz} \t \t {uygulanacakBsmv} \t  \t {uygulanacakKkdf} \t \t {kalanPara}");
                toplamFaiz += uygulanacakFaiz;
                toplamBsmvTutar += uygulanacakBsmv;
                toplamKkdfTutar += uygulanacakKkdf;
            }
            Console.WriteLine($"*  \t {aylikTaksitTutari*ay} \t {kredi} \t \t {Math.Round(toplamFaiz , 2)} \t {toplamBsmvTutar} \t \t {toplamKkdfTutar}");

        }
    }
}
