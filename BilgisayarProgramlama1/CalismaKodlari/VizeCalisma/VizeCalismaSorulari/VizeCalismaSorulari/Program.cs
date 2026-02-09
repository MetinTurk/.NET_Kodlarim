using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;

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

            #region Dijital imza doğrulama sistemi

            //DİJİTAL İMZA DOĞRULAMA SİSTEMİ (SECURE-LOG)

            //string hamLogVerisi = "USER_A_ADM, 01:23:45, SIG_PASS_A; USER_B_GUE, 14:05:10, SIG_HATA_02; USER_C_DEV, 09:40:22, SIG_PASS_B; USER_D_ADM, 02:59:59, SIG_FAIL_01; USER_E_DEV, 11:30:00, SIG_SUCCESS_OK; USER_F_GUE, 23:59:00, SIG_PASS_C ; USER_G_ADM, 00:01:00, SIG_PASS_A";

            //string[] duzenliLogVerisi = hamLogVerisi.Split(';');
            //int toplamRiskSkoru = 0, toplamKayitSayisi = 0;
            //Console.WriteLine("Index\tKullanıcı Kodu\tSaat\tDoğrulama Kodu\tSkor\tToplam Skor");
            //for (int i = 0; i < duzenliLogVerisi.Length; i++)
            //{
            //    duzenliLogVerisi[i] = duzenliLogVerisi[i].Trim();
            //    if (string.IsNullOrWhiteSpace(duzenliLogVerisi[i]))
            //    {
            //        continue;
            //    }
            //    string[] ayrilmisLogVerisi = duzenliLogVerisi[i].Split(",");
            //    string kullaniciKodu = ayrilmisLogVerisi[0];
            //    string girisSaatiStr = ayrilmisLogVerisi[1].Trim();
            //    string dogrulamaKodu = ayrilmisLogVerisi[2];

            //    string duzeltilmisSaat = girisSaatiStr.PadLeft(8, '0');

            //    if (duzeltilmisSaat.StartsWith("00:") ||
            //        duzeltilmisSaat.StartsWith("01:") ||
            //        duzeltilmisSaat.StartsWith("02:"))
            //    {
            //        toplamRiskSkoru -= 20;
            //        Console.WriteLine($"{kullaniciKodu} için erken erişim riski tespit edildi! (-20)");
            //        Console.WriteLine($"Toplam skor: {toplamRiskSkoru}");
            //    }
            //    if (dogrulamaKodu.Contains("FAIL") || dogrulamaKodu.Contains("HATA"))
            //    {
            //        toplamRiskSkoru -= 30;
            //        Console.WriteLine($"{dogrulamaKodu} için hata tespit edildi! (-30)");
            //        Console.WriteLine($"Toplam skor: {toplamRiskSkoru}");
            //    }
            //    if (kullaniciKodu.Contains("_ADM"))
            //    {
            //        toplamRiskSkoru += 10;
            //        Console.WriteLine($"{kullaniciKodu} admin olduğu için (+10)");
            //        Console.WriteLine($"Toplam skor: {toplamRiskSkoru}");
            //    }
            //    if (dogrulamaKodu.EndsWith("SUCCESS_OK"))
            //    {
            //        toplamRiskSkoru += 50;
            //        Console.WriteLine($"{dogrulamaKodu} başarılı olduğu için (+50)");
            //        Console.WriteLine($"Toplam skor: {toplamRiskSkoru}");
            //    }
            //    if (dogrulamaKodu.Length < 10)
            //    {
            //        toplamRiskSkoru -= 5;
            //        Console.WriteLine($"{dogrulamaKodu} kısa ve eksik dogrulama kodu");
            //        Console.WriteLine($"Toplam skor: {toplamRiskSkoru}");
            //    }

            //    toplamKayitSayisi++;
            //}
            //Console.WriteLine($"Analiz Edilen Kayıt Sayısı: {toplamKayitSayisi} GENEL SİSTEM RİSK SKORU: {toplamRiskSkoru}");

            #endregion

            #region Kilitli otopark yonetim sistemi
            ////KILITLI OTOPARK YÖNETİM SİSTEMİ (PARK-AUDIT)

            //string hamVeri = "Kat:1_Daire:5_T:1_HIZLI \t Kat:2_Daire:3_T:2_CRITIC \t Kat:3_Daire:4_T:0_NORMAL \t Kat:4_Daire:2_T:1_MINI";

            //string[] parcaliVeri = hamVeri.Split('\t');
            //int[][] otopark = new int[4][];
            //int denetimSkoru = 100;
            ////Console.WriteLine("Kat\tDaire\tEski Durum\tYeni Durum\tPuan Değişimi\tToplam Skor");
            //for (int i = 0; i < parcaliVeri.Length; i++)
            //{
            //    string[] duzenliVeri = parcaliVeri[i].Trim().Split("_");
            //    string daireSayisi = duzenliVeri[1];
            //    string[] daireSayisiDizisi = daireSayisi.Split(":");
            //    otopark[i] = new int[int.Parse(daireSayisiDizisi[1])];
            //    for (int j = 0; j < otopark[i].Length; j++)
            //    {
            //        string[] talepEdilenOtoparkSayisi = duzenliVeri[2].Split(":");
            //        otopark[i][j] = int.Parse(talepEdilenOtoparkSayisi[1]);
            //        if (otopark[i][j] == 2 && duzenliVeri[3].Contains("CRITIC"))
            //        {
            //            denetimSkoru -= 25;
            //            Console.WriteLine("Hatalı işlem : (-25)");
            //            Console.WriteLine("Toplam Denetim puanı = " + denetimSkoru);
            //        }
            //        if (otopark[i][j] == 0 && i == 2)
            //        {
            //            denetimSkoru += 15;
            //            Console.WriteLine("Otopark kullanmadığınız ve 3. katta olduğunuz için tebrikler (+15)");
            //            Console.WriteLine("Toplam denetim puanı :" + denetimSkoru);
            //        }
            //        if(i == 0 && otopark[i][j] == 1 && duzenliVeri[3].EndsWith("HIZLI"))
            //        {
            //            denetimSkoru -= 10;
            //            Console.WriteLine("Hatalı işlem :(-10)");
            //            Console.WriteLine("Toplam denetim puani: " + denetimSkoru);
            //        }
            //        if(i == 3 && otopark[i][j] == 1)
            //        {
            //            otopark[i][j] = 0;
            //            denetimSkoru -= 5;
            //            Console.WriteLine("Dizi değeri değişti: (-5)");
            //            Console.WriteLine("Toplam denetim puani: " + denetimSkoru);
            //        }
            //        if (i == 1 && j == 0)
            //        {
            //            otopark[i][j] = 1;
            //            denetimSkoru += 5;
            //            Console.WriteLine("Dizi Değeri güncellendi (+5)");
            //            Console.WriteLine("Toplam denetim puani: " + denetimSkoru);
            //        }
            //    }
            //} 
            #endregion


            #region Dinamik Lojistik ve Tehlikeli Madde Simülasyonu

            //Dinamik Lojistik ve Tehlikeli Madde Simülasyonu


            //double standartBirimFiyati = 3.5;
            //double BirimFiyatiHesapla(double agirlik)
            //{
            //    return agirlik * standartBirimFiyati;
            //}


            //string[] sevkiyatAdi = {
            //    "Laptop", "Kimyasal", "Gıda", "Makine", "Pil",
            //    "Mobilya", "Cam Şişe", "Elektronik", "Tekstil", "Hammadde",
            //    "İlaç", "Ambalaj"
            //};
            //            double[] agirlikKg = {
            //    15.0, 40.0, 25.0, 150.0, 8.0,
            //    120.0, 60.0, 10.5, 30.0, 500.0,
            //    5.0, 2.5
            //};
            //            string[] kategoriKodu = {
            //    "STD", "HAZ", "STD", "BULK", "HAZ",
            //    "BULK", "FRG", "STD", "STD", "BULK",
            //    "HAZ", "STD"
            //};


            //int baslangicTehlikeliMaddeSayisi = 0;
            //double sabitTehlikeEkUcreti = 300;
            //double sabitIslemUcreti = 120.00;
            //double temelMaliyet = 0;
            //double toplamFatura = 0;
            //Console.WriteLine("Sevkiyat \t Ağırlık \t Kategpri \t Temel Maliyet \t Tehlike Ek Ucreti \t İndirim Tutari \t Risk Primi \t Toplam Fatura");
            //for (int i = 0; i < sevkiyatAdi.Length; i++)
            //{
            //    double tehlikeUcreti = 0;
            //    double indirimTutari = 0;
            //    double riskPrimi = 0;
            //    temelMaliyet = BirimFiyatiHesapla(agirlikKg[i]);
            //    if (kategoriKodu[i].Contains("BULK") && agirlikKg[i] >100)
            //    {
            //        indirimTutari = -1*(temelMaliyet * 0.15);
            //    }
            //    else if (kategoriKodu[i].Contains("HAZ") && baslangicTehlikeliMaddeSayisi >= 2)
            //    {
            //        tehlikeUcreti = sabitTehlikeEkUcreti;
            //        riskPrimi = (temelMaliyet + tehlikeUcreti) * 0.05;
            //        baslangicTehlikeliMaddeSayisi++;
            //    }
            //    else if (kategoriKodu[i].Contains("HAZ"))
            //    {
            //        tehlikeUcreti = sabitTehlikeEkUcreti;
            //        baslangicTehlikeliMaddeSayisi++;
            //    }
            //    temelMaliyet = BirimFiyatiHesapla(agirlikKg[i])+ indirimTutari + tehlikeUcreti +  riskPrimi;
            //    toplamFatura = temelMaliyet + sabitIslemUcreti;
            //    Console.WriteLine($"{i+1} \t \t {agirlikKg[i]} \t \t {kategoriKodu[i]} \t \t {temelMaliyet} \t \t {tehlikeUcreti} \t \t \t {indirimTutari} \t \t \t {riskPrimi} \t \t {toplamFatura}");
            //} 
            #endregion

            #region Performans ve Prim Hesaplama Simülasyonu
            ////Dinamik Performans ve Prim Hesaplama Simülasyonu


            //Console.WriteLine("Gün \t Aktif Hedef \t Günlük Üretim \t Sabit Ücret \t Prim Tutarı \t Ceza Kesintisi \t Günlük Toplam Kazanç \t Bir Sonraki Hedef");
            //int[] gunlukUretim = { 1100 , 1350 , 900 , 1400 , 1150};
            //double sabitGunlukUcret = 350;
            //double baslangicHedefi = 1200;
            //double primOrani = 0.25;

            //for (int i = 0; i < gunlukUretim.Length; i++)
            //{
            //    double cezaTutari = 0;
            //    double primTutari = 0;
            //    double sonrakiHedef = 0;
            //    if (gunlukUretim[i] > baslangicHedefi)
            //    {
            //        primTutari = (gunlukUretim[i] - baslangicHedefi ) * primOrani;
            //        sonrakiHedef = baslangicHedefi * 1.10;
            //    }
            //    else if (gunlukUretim[i] < baslangicHedefi * 0.8)
            //    {
            //        cezaTutari = 80;
            //        sonrakiHedef = baslangicHedefi * 0.95;
            //    }
            //    else
            //    {
            //        sonrakiHedef = baslangicHedefi;
            //    }
            //    double gunlukToplamKazanc = sabitGunlukUcret + cezaTutari + primTutari;
            //    Console.WriteLine($"{i + 1} \t {baslangicHedefi} \t \t {gunlukUretim[i]} \t \t {sabitGunlukUcret} \t \t {primTutari} \t \t {cezaTutari}  \t \t \t {gunlukToplamKazanc} \t \t \t {sonrakiHedef}");
            //    baslangicHedefi = sonrakiHedef;
            //} 
            #endregion

            #region KUANTUM GÜVENLİK PROTOKOLÜ
            ////KUANTUM GÜVENLİK PROTOKOLÜ (Q-SEC) ANALİZİ
            //const string HamVeriAkisi = "QSEC55ALPHA001QSEC44BETAERRZNO_PROTOKOL_XXQSEC55GAB_BETAQSEC40ALPHAABCABERRC12345678";
            //string[] parcaliVeri = new string[HamVeriAkisi.Length/14];
            //int sayac = 0;


            //StringBuilder sb = new StringBuilder();
            //sb.AppendLine("Q-SEC Analiz Raporu\n-------------------");
            //for (int i = 0; i < HamVeriAkisi.Length; i+=14)
            //{
            //    int guvenPuani = 100;
            //    int cezaPuani = 0;
            //    parcaliVeri[sayac] = HamVeriAkisi.Substring(i, 14);
            //    int aCeza = 0, bCeza = 0, cCeza = 0, dCeza = 0;
            //    sb.Append($"{sayac + 1}. raporun: Kod: {parcaliVeri[sayac]} ");
            //    if (parcaliVeri[sayac].Substring(0,4) == "QSEC")
            //    {
            //        aCeza = 25;;

            //    }
            //    if (parcaliVeri[sayac].Substring(4,2) == "55" && !parcaliVeri[sayac].EndsWith("BETA"))
            //    {
            //        bCeza = -15;                    
            //    }
            //    if (parcaliVeri[sayac].Contains("ERR") || Char.IsDigit(char.Parse(parcaliVeri[sayac].Substring(parcaliVeri[sayac].Length - 1, 1))))
            //    {
            //        cCeza = -50;                    
            //    }
            //    if (parcaliVeri[sayac].IndexOf("ALPHA") != 0 && parcaliVeri[sayac].IndexOf("ALPHA") != -1)
            //    {
            //        dCeza = 40;
            //    }
            //    cezaPuani = aCeza + bCeza + cCeza + dCeza;
            //    guvenPuani += cezaPuani;
            //    sb.Append($"| Skor: A:{aCeza}\t|B:{bCeza}\t|C:{cCeza}\t|D:{dCeza}\t|Blok skoru: {cezaPuani}  |Toplam Güven Puanı: {guvenPuani}\n");
            //    sayac++;
            //}
            //Console.WriteLine(sb.ToString()); 
            #endregion


            //StringBuilder rapor = new StringBuilder();
            //rapor.Append("QSEC-RAPOR-BAŞLANGIÇ|");
            //rapor.Append("PAKET_ID:551-DURUM:OK|");
            //rapor.Append("PAKET_ID:552-DURUM:CORRUPT|");
            //rapor.Append("PAKET_ID:553-DURUM:OK|");
            //rapor.Append("HATA_KODU:NOISE_FLTR_8X_AKTİF|"); // Bu satır gereksiz
            //rapor.Append("PAKET_ID:554-DURUM:PENDING|");
            //rapor.Append("QSEC-RAPOR-BİTİŞ");

            //Console.WriteLine("--- Ham Rapor ---");
            //Console.WriteLine(rapor.ToString());
            //Console.WriteLine("-----------------\n");

            //var hataliIndex = rapor.ToString().IndexOf("HATA");
            //rapor.Remove(hataliIndex,  31);
            //rapor.Replace("CORRUPT", "BAGLANTI_HATASI");
            //rapor.Insert(0, "KRİTİK_UYARI:[02/11/2025] |");
            //rapor.Replace("|", "\n");
            //Console.WriteLine(rapor.ToString());

            //----------------------------------------------------------------------------------------------------------//
            //StringBuilder logKaydi = new StringBuilder();
            //logKaydi.AppendLine("--- Q-SEC GÜNLÜK KAYIT BAŞLANGICI ---");
            //logKaydi.AppendLine("PAKET:A-DURUM:STABLE");
            //logKaydi.AppendLine("PAKET:B-DURUM:STABLE");
            //logKaydi.AppendLine("UYARI: SİSTEM_GÜRÜLTÜSÜ_XF01_YOKSAY"); // Bu satır gereksiz
            //logKaydi.AppendLine("PAKET:C-DURUM:UNSTABLE");
            //logKaydi.AppendLine("PAKET:D-DURUM:STABLE");
            //logKaydi.AppendLine("ÖNCELİK_KODU:CRITICAL_99X"); // Bu veri taşınmalı
            //logKaydi.AppendLine("--- Q-SEC GÜNLÜK KAYIT BİTİŞİ ---");

            //Console.WriteLine("--- ORİJİNAL LOG KAYDI ---");
            //Console.WriteLine(logKaydi.ToString());
            //Console.WriteLine("--------------------------");

            //var hataliIndex = logKaydi.ToString().IndexOf("UYARI");
            //logKaydi.Remove(hataliIndex, 37);
            //logKaydi.Replace("STABLE", "GUVENLI");
            //int aktarilicakIndex = logKaydi.ToString().IndexOf("ÖNCELİK_KODU");
            //string aktarilicakString = logKaydi.ToString().Substring(aktarilicakIndex, 27);
            //logKaydi.Remove(aktarilicakIndex,27);
            //logKaydi.Insert(0,aktarilicakString);
            //logKaydi.AppendLine("İŞLEM TAMAMLANDI: [02/11/2025]");
            //Console.WriteLine(logKaydi.ToString());


            // --- BAŞLANGIÇ KODU ---
            StringBuilder queueBuffer = new StringBuilder();
            queueBuffer.AppendLine("TASK_ID:101-CMD:INIT_SEQ");
            queueBuffer.AppendLine("[REPEAT:3:CMD_PING_NODE]"); // 3 kez "CMD_PING_NODE" olarak genişlemeli
            queueBuffer.AppendLine("TASK_ID:102-CMD:CHECK_PWR");
            queueBuffer.AppendLine("[NULL_OP]"); // Bu satır tamamen silinmeli
            queueBuffer.AppendLine("[NULL_OP]"); // Bu satır tamamen silinmeli
            queueBuffer.AppendLine("[CRITICAL_TASK:CMD_REBOOT_CORE]"); // Başına bayrak eklenmeli
            queueBuffer.AppendLine("TASK_ID:103-CMD:VERIFY_CRC");
            queueBuffer.AppendLine("[REPEAT:2:CMD_CALIBRATE_GYRO]"); // 2 kez "CMD_CALIBRATE_GYRO" olarak genişlemeli
            queueBuffer.AppendLine("--- QUEUE END ---");

            Console.WriteLine("--- Ham Komut Kuyruğu ---");
            Console.WriteLine(queueBuffer.ToString());
            Console.WriteLine("-------------------------");

            int hataliIndex = queueBuffer.ToString().IndexOf("[NULL_OP]");
            queueBuffer.Remove(hataliIndex, 22);
            
            queueBuffer.Insert(queueBuffer.ToString().IndexOf("[CRITICA") , "PRIORITY_FLAG:HIGH\n");
            int tekrarEdenSatirIndex = 0;
            
            do
            {
                tekrarEdenSatirIndex = queueBuffer.ToString().IndexOf("[REPEAT");
                int tekrarEdenLogSayiIndexi = tekrarEdenSatirIndex + 8;
                int commadTekrarEdenIndexBaslangic = tekrarEdenLogSayiIndexi + 2;
                int commadTekrarEdenIndexBitis = queueBuffer.ToString().IndexOf("]", commadTekrarEdenIndexBaslangic);
                int tekrarSayisi = int.Parse(queueBuffer[tekrarEdenLogSayiIndexi].ToString());
                string? commad = null;
                string commadAtama = queueBuffer.ToString();
                commad = commadAtama.Substring(commadTekrarEdenIndexBaslangic, commadTekrarEdenIndexBitis - commadTekrarEdenIndexBaslangic);
                for (int i = 0; i < tekrarSayisi; i++)
                {
                    queueBuffer.Insert(tekrarEdenSatirIndex, commad+"\n");
                }
                tekrarEdenSatirIndex = queueBuffer.ToString().IndexOf("[REPEAT");
                tekrarEdenLogSayiIndexi = tekrarEdenSatirIndex + 8;
                commadTekrarEdenIndexBaslangic = tekrarEdenLogSayiIndexi + 2;
                commadTekrarEdenIndexBitis = queueBuffer.ToString().IndexOf("]", commadTekrarEdenIndexBaslangic);
                queueBuffer.Remove(tekrarEdenSatirIndex - 1, commadTekrarEdenIndexBitis - tekrarEdenSatirIndex + 2);
                tekrarEdenSatirIndex = queueBuffer.ToString().IndexOf("[REPEAT");
            }
            while (tekrarEdenSatirIndex != -1);
            
            //Console.WriteLine(queueBuffer[commadTekrarEdenIndexBitis]);

            //Console.WriteLine(queueBuffer[tekrarEdenLogSayiIndexi]);
            
            Console.WriteLine(queueBuffer.ToString());

            



        }
    }
}
