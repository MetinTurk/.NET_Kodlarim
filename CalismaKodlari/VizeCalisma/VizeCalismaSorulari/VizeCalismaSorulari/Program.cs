using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

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

            #region Önemli soru
            //double bsmv = 0.1, kkdf = 0.15, faiz = 0.02, kredi = 10000;
            //int ay = 4;

            //double toplamFaizOrani = faiz * (bsmv + kkdf + 1);
            //double aylikTaksitTutari = Math.Round((kredi * (toplamFaizOrani * Math.Pow(1 + toplamFaizOrani, ay))) / (Math.Pow(1 + toplamFaizOrani, ay) - 1), 2);

            //Console.WriteLine("Ay \t Taksit \t Anapara \t Faiz \t \t BsmvTutar \t KkdfTutar \t KalanAnaPara ");
            //double toplamFaiz = 0, toplamBsmvTutar = 0, toplamKkdfTutar = 0, kalanPara = kredi;
            //for (int i = 0; i < ay; i++)
            //{
            //    double uygulanacakFaiz = Math.Round(kalanPara * faiz, 2);
            //    double uygulanacakBsmv = Math.Round(uygulanacakFaiz * bsmv,2);
            //    double uygulanacakKkdf = Math.Round(uygulanacakFaiz * kkdf, 2);
            //    double aylikAnaPara = Math.Round(aylikTaksitTutari - (uygulanacakFaiz + uygulanacakBsmv + uygulanacakKkdf) ,2);
            //    kalanPara = Math.Round(kalanPara - aylikAnaPara, 2);
            //    Console.WriteLine($"0{i+1} \t {aylikTaksitTutari} \t {aylikAnaPara} \t {uygulanacakFaiz} \t \t {uygulanacakBsmv} \t  \t {uygulanacakKkdf} \t \t {kalanPara}");
            //    toplamFaiz += uygulanacakFaiz;
            //    toplamBsmvTutar += uygulanacakBsmv;
            //    toplamKkdfTutar += uygulanacakKkdf;
            //}
            //Console.WriteLine($"*  \t {aylikTaksitTutari*ay} \t {kredi} \t \t {Math.Round(toplamFaiz , 2)} \t {toplamBsmvTutar} \t \t {toplamKkdfTutar}"); 
            #endregion

            //DİJİTAL İMZA DOĞRULAMA SİSTEMİ (SECURE-LOG)

            string hamLogVerisi = "USER_A_ADM, 01:23:45, SIG_PASS_A; USER_B_GUE, 14:05:10, SIG_HATA_02; USER_C_DEV, 09:40:22, SIG_PASS_B; USER_D_ADM, 02:59:59, SIG_FAIL_01; USER_E_DEV, 11:30:00, SIG_SUCCESS_OK; USER_F_GUE, 23:59:00, SIG_PASS_C ; USER_G_ADM, 00:01:00, SIG_PASS_A";

            string[] duzenliLogVerisi  = hamLogVerisi.Split(';');
            int toplamRiskSkoru = 0 , toplamKayitSayisi = 0;
            Console.WriteLine("Index\tKullanıcı Kodu\tSaat\tDoğrulama Kodu\tSkor\tToplam Skor");
            for (int i = 0; i < duzenliLogVerisi.Length; i++)
            {
                duzenliLogVerisi[i] = duzenliLogVerisi[i].Trim();
                if (string.IsNullOrWhiteSpace(duzenliLogVerisi[i]))
                {
                    continue;
                }
                string[] ayrilmisLogVerisi = duzenliLogVerisi[i].Split(",");
                string kullaniciKodu = ayrilmisLogVerisi[0];
                string girisSaatiStr = ayrilmisLogVerisi[1].Trim();
                string dogrulamaKodu = ayrilmisLogVerisi[2];

                string duzeltilmisSaat = girisSaatiStr.PadLeft(8, '0');

                if (duzeltilmisSaat.StartsWith("00:") ||
                    duzeltilmisSaat.StartsWith("01:") ||
                    duzeltilmisSaat.StartsWith("02:"))
                {
                    toplamRiskSkoru -= 20;
                    Console.WriteLine($"{kullaniciKodu} için erken erişim riski tespit edildi! (-20)");
                    Console.WriteLine($"Toplam skor: {toplamRiskSkoru}");
                }
                if(dogrulamaKodu.Contains("FAIL") || dogrulamaKodu.Contains("HATA"))
                {
                    toplamRiskSkoru -= 30;
                    Console.WriteLine($"{dogrulamaKodu} için hata tespit edildi! (-30)");
                    Console.WriteLine($"Toplam skor: {toplamRiskSkoru}");
                }
                if (kullaniciKodu.Contains("_ADM"))
                {
                    toplamRiskSkoru += 10;
                    Console.WriteLine($"{kullaniciKodu} admin olduğu için (+10)");
                    Console.WriteLine($"Toplam skor: {toplamRiskSkoru}");
                }
                if (dogrulamaKodu.EndsWith("SUCCESS_OK"))
                {
                    toplamRiskSkoru += 50;
                    Console.WriteLine($"{dogrulamaKodu} başarılı olduğu için (+50)");
                    Console.WriteLine($"Toplam skor: {toplamRiskSkoru}");
                }
                if(dogrulamaKodu.Length < 10)
                {
                    toplamRiskSkoru -= 5;
                    Console.WriteLine($"{dogrulamaKodu} kısa ve eksik dogrulama kodu");
                    Console.WriteLine($"Toplam skor: {toplamRiskSkoru}");
                }
                
                toplamKayitSayisi++;
            }
            Console.WriteLine($"Analiz Edilen Kayıt Sayısı: {toplamKayitSayisi} GENEL SİSTEM RİSK SKORU: {toplamRiskSkoru}");
        }
    }
}
