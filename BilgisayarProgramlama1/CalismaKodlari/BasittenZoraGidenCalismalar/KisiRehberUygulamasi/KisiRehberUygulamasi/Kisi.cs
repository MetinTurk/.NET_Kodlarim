using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiRehberUygulamasi
{
    internal class Kisi
    {
        private string _ad;
        private string _soyad;
        private string _telNo;
        private string _tc;

        public Kisi(string ad, string soyad, string telNo , string tc)
        {
            _ad = ad;
            _soyad = soyad;
            _telNo = telNo;
            _tc = tc;
        }

        public string Ad { get => _ad; set => _ad = value; }
        public string Soyad { get => _soyad; set => _soyad = value; }
        public string TelNo { get => _telNo; set => _telNo = value; }
        public string TC { get => _tc; set => _tc = value; }

        static public List<Kisi> kisiler = new List<Kisi>();
        static public void HataMesaj()
        {
            Console.WriteLine("Hatalı giriş yaptınız Lütfen tekrar deneyiniz.");
            Console.WriteLine("--------------------------------------------");
        }
        static private void AramaMesaji(int sayac, Kisi item)
        {
            if(item == null)
            {
                Console.WriteLine("Liste boş");
            }
            else
            {
                Console.WriteLine($"Aradığınız kişi bulundu: {sayac + 1}. kişi, Adı: {item.Ad} Soyadı: {item.Soyad} Telefonu: {item.TelNo} TC Kimliği: {item.TC}");
            }
                
        }
        static private void SilmeMesaji(int sayac, Kisi item)
        {
            if (item == null)
            {
                Console.WriteLine("Liste boş");
            }
            else
            {
                Console.WriteLine($"Silmek istediğiniz kişi bulundu: {sayac + 1}. kişi, Adı: {item.Ad} Soyadı: {item.Soyad} Telefonu: {item.TelNo} TC Kimliği: {item.TC}");
            }

        }
        static private void ListelemeMesaji(int sayac, Kisi item)
        {
            if(item == null)
            {
                Console.WriteLine("Liste boş");
            }
            else 
            {
                Console.WriteLine($"{sayac + 1}. kişi, Adı: {item.Ad} Soyadı: {item.Soyad} Telefonu: {item.TelNo} TC Kimliği: {item.TC}");
            }
                
        }
        static public void CizgiBas()
        {
            Console.WriteLine("--------------------------------------------");
        }

        static public void KisiBul(string aramaTuru, string aranan)
        {
            int sayac = 0;
            var kontrol = false;
            foreach (var item in kisiler)
            {
                if(aramaTuru == "Ad" && item.Ad == aranan)
                {
                    AramaMesaji(sayac, item);
                    kontrol = true;
                    sayac++;
                }
                else if(aramaTuru == "Soyad" && item.Soyad == aranan)
                {
                    AramaMesaji(sayac, item);
                    kontrol = true;
                    sayac++;
                }
                else if(aramaTuru == "Numara" && item.TelNo == aranan)
                {
                    AramaMesaji(sayac, item);
                    kontrol = true;
                    sayac++;
                }
                else if(aramaTuru == "TC" && item.TC == aranan)
                {
                    AramaMesaji(sayac, item);
                    kontrol = true;
                    sayac++;
                }
            }
            if (!kontrol)
            {
                HataMesaj();
            }
        }
        static public void KisiSil(string aramaTuru, string aranan)
        {
            int sayac = 0;
            List<Kisi> bulunanKisiler = new List<Kisi>();
            foreach (var item in kisiler)
            {
                if (aramaTuru == "Ad" && item.Ad == aranan)
                {
                    SilmeMesaji(sayac, item);
                    sayac++;
                    bulunanKisiler.Add(item);
                }
                else if (aramaTuru == "Soyad" && item.Soyad == aranan)
                {
                    SilmeMesaji(sayac, item);
                    sayac++;
                    bulunanKisiler.Add(item);
                }
                else if (aramaTuru == "Numara" && item.TelNo == aranan)
                {
                    SilmeMesaji(sayac, item);
                    sayac++;
                    bulunanKisiler.Add(item);
                }
                else if (aramaTuru == "TC" && item.TC == aranan)
                {
                    SilmeMesaji(sayac, item);
                    sayac++;
                    bulunanKisiler.Add(item);
                }
                
            }
            if (bulunanKisiler == null)
            {
                HataMesaj();
            }
            else
            {
                if(bulunanKisiler.Count == 1)
                {
                    
                    do
                    {
                        Console.Write("Bu kişiyi silmek istiyor musunuz (e/h): ");
                        var islem = Console.ReadLine().ToUpper();
                        if (islem == "E")
                        {
                            int sayacListe = 0;
                            foreach (var item in kisiler)
                            {
                                if (item == bulunanKisiler[0])
                                {
                                    break;
                                }
                                sayacListe++;
                            }
                            kisiler.RemoveAt(sayacListe);
                            Console.WriteLine("Silme işlemi başarıyla gerçekleşmiştir.");
                            break;
                        }
                        else if (islem == "H")
                        {
                            Console.WriteLine("Silme işlemi iptal edilmiştir.");
                            break;
                        }
                        else
                        {
                            HataMesaj();
                        }
                    } while (true);
                    CizgiBas();
                }
                else
                {

                    int kisiSilSecim;
                    do
                    {
                        Console.Write("Bu kişilerden hangisini silmek istiyorsunuz: ");
                        var kisiSilSecimString = Console.ReadLine();
                        if (int.TryParse(kisiSilSecimString, out kisiSilSecim) && kisiSilSecim > 0 && kisiSilSecim <= bulunanKisiler.Count())
                        {
                            break;
                        }
                        else
                        {
                            Kisi.HataMesaj();
                        }
                    } while (true);
                    sayac = 0;
                    foreach (var item in bulunanKisiler)
                    {
                        if (item == bulunanKisiler[kisiSilSecim - 1])
                        {
                            Console.WriteLine($"{sayac + 1}. kişi, Adı: {item.Ad} Soyadı: {item.Soyad} Telefonu: {item.TelNo} TC Kimliği: {item.TC}");
                            
                        }
                        
                    }
                    do
                    {
                        Console.Write("Bu kişiyi silmek istiyor musunuz (e/h): ");
                        var islem = Console.ReadLine().ToUpper();
                        if (islem == "E")
                        {
                            int sayacListe = 0;
                            foreach (var item in kisiler)
                            {
                                if(item == bulunanKisiler[kisiSilSecim - 1])
                                {
                                    break;
                                }
                                sayacListe++;
                            }
                            kisiler.RemoveAt(sayacListe);
                            Console.WriteLine("Silme işlemi başarıyla gerçekleşmiştir.");
                            break;
                        }
                        else if (islem == "H")
                        {
                            Console.WriteLine("Silme işlemi iptal edilmiştir.");
                            break;
                        }
                        else
                        {
                            HataMesaj();
                        }
                    } while (true);




                    CizgiBas();
                }
            }
        }
        static public void KisiListele()
        {
            int sayac = 0;
            foreach (var item in Kisi.kisiler)
            {
                ListelemeMesaji(sayac, item);
                sayac++;
            }
        }
    }
}
