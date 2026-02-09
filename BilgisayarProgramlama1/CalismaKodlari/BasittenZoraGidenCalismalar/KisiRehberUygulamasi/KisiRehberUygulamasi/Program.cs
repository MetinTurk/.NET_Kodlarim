namespace KisiRehberUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kişi Rehber Otomasyonuna Hoşgeldiniz.");
            int secim;
            bool kontrol;
            do
            {
                kontrol = false;
                do
                {
                    Console.Write("1-) Kişi Ekle\n2-) Kişi Listele\n3-) Kişi Bul\n4-) Kişi Sil\nLütfen seçin yapınız: ");
                    var secimString = Console.ReadLine();
                    if (int.TryParse(secimString, out secim) && secim > 0 && secim < 5)
                    {
                        break;
                    }
                    else
                    {
                        Kisi.HataMesaj();
                    }

                } while (true);
                if (secim == 1)
                {
                    Console.WriteLine("Lütfen kaydetmek istediğiniz kişinin bilgilerini giriniz.");
                    Console.Write("Adı: ");
                    var ad = Console.ReadLine();
                    Console.Write("Soyadi: ");
                    var soyad = Console.ReadLine();
                    string tc;
                    
                    do
                    {
                        Console.Write("TC: ");
                        tc = Console.ReadLine().Trim();
                        
                        if(tc.Length == 11 && long.TryParse(tc , out var tcLong)){
                            if(tcLong > 0)
                            {
                                break;
                            }
                            else
                            {
                                Kisi.HataMesaj();
                            }
                        }
                        else
                        {
                            Kisi.HataMesaj();
                        }
                    } while (true);
                    
                    string numara;
                    do
                    {
                        Console.Write("Telefon: ");
                        numara = Console.ReadLine();

                        if (numara.Length == 11 && long.TryParse(numara, out var numaraLong) && numara.StartsWith("0"))
                        {
                            if (numaraLong > 0)
                            {
                                break;
                            }
                            else
                            {
                                Kisi.HataMesaj();
                            }
                        }
                        else
                        {
                            Kisi.HataMesaj();
                        }
                    } while (true);
                    Kisi yeniKisi = new Kisi(ad,  soyad , numara , tc);
                    Kisi.kisiler.Add(yeniKisi);
                    Console.WriteLine("Kişiniz Rehberinize Başarıyla Eklenmiştir.");
                }
                else if (secim == 2)
                {
                    Kisi.KisiListele();
                    Kisi.CizgiBas();
                }
                else if (secim == 3)
                {
                    int kisiBulSecim;
                    do
                    {
                        Console.Write("1-) Ad ile ara\n2-) Soyad ile ara\n3-) Numara ile ara\n4-) TC kimlik ile ara \nLütfen seçin yapınız: ");
                        var kisiBulSecimString = Console.ReadLine();
                        if (int.TryParse(kisiBulSecimString, out kisiBulSecim) && kisiBulSecim > 0 && kisiBulSecim < 5)
                        {
                            break;
                        }
                        else
                        {
                            Kisi.HataMesaj();
                        }
                    } while (true);
                    if(kisiBulSecim == 1)
                    {
                        Console.Write("Aramak istediğiniz isimi giriniz: ");
                        var aranan = Console.ReadLine();
                        var aramaTuru = "Ad";
                        Kisi.KisiBul(aramaTuru, aranan);
                    }
                    else if(kisiBulSecim == 2)
                    {
                        Console.Write("Aramak istediğiniz soyadı giriniz: ");
                        var aranan = Console.ReadLine();
                        var aramaTuru = "Soyad";
                        Kisi.KisiBul(aramaTuru, aranan);
                    }
                    else if(kisiBulSecim == 3)
                    {
                        string aranan;
                        do
                        {
                            Console.Write("Aramak istediğiniz numarayı giriniz: ");
                            aranan = Console.ReadLine();

                            if (aranan.Length == 11 && long.TryParse(aranan, out var arananLong) && aranan.StartsWith("0"))
                            {
                                if (arananLong > 0)
                                {
                                    break;
                                }
                                else
                                {
                                    Kisi.HataMesaj();
                                }
                            }
                            else
                            {
                                Kisi.HataMesaj();
                            }
                        } while (true);
                        var aramaTuru = "Numara";
                        Kisi.KisiBul(aramaTuru, aranan);
                    }
                    else if(kisiBulSecim == 4)
                    {
                        string aranan;
                        do
                        {
                            Console.Write("Aramak istediğiniz TC Kimliği giriniz: ");
                            aranan = Console.ReadLine();

                            if (aranan.Length == 11 && long.TryParse(aranan, out var arananLong))
                            {
                                if (arananLong > 0)
                                {
                                    break;
                                }
                                else
                                {
                                    Kisi.HataMesaj();
                                }
                            }
                            else
                            {
                                Kisi.HataMesaj();
                            }
                        } while (true);
                        var aramaTuru = "TC";
                        Kisi.KisiBul(aramaTuru, aranan);
                    }
                }
                else
                {
                    int kisiSilSecim;
                    do
                    {
                        Console.Write("1-) Ad ile sil\n2-) Soyad ile sil\n3-) Numara ile sil\n4-) TC kimlik ile sil \nLütfen seçin yapınız: ");
                        var kisiSilSecimString = Console.ReadLine();
                        if (int.TryParse(kisiSilSecimString, out kisiSilSecim) && kisiSilSecim > 0 && kisiSilSecim < 5)
                        {
                            break;
                        }
                        else
                        {
                            Kisi.HataMesaj();
                        }
                    } while (true);
                    if (kisiSilSecim == 1)
                    {
                        Console.Write("Silmek istediğiniz isimi giriniz: ");
                        var aranan = Console.ReadLine();
                        var aramaTuru = "Ad";
                        Kisi.KisiSil(aramaTuru, aranan);
                    }
                    else if (kisiSilSecim == 2)
                    {
                        Console.Write("Silmek istediğiniz soyadı giriniz: ");
                        var aranan = Console.ReadLine();
                        var aramaTuru = "Soyad";
                        Kisi.KisiSil(aramaTuru, aranan);
                    }
                    else if (kisiSilSecim == 3)
                    {
                        string aranan;
                        do
                        {
                            Console.Write("Silmek istediğiniz numarayı giriniz: ");
                            aranan = Console.ReadLine();

                            if (aranan.Length == 11 && long.TryParse(aranan, out var arananLong) && aranan.StartsWith("0"))
                            {
                                if (arananLong > 0)
                                {
                                    break;
                                }
                                else
                                {
                                    Kisi.HataMesaj();
                                }
                            }
                            else
                            {
                                Kisi.HataMesaj();
                            }
                        } while (true);
                        var aramaTuru = "Numara";
                        Kisi.KisiSil(aramaTuru, aranan);
                    }
                    else if (kisiSilSecim == 4)
                    {
                        string aranan;
                        do
                        {
                            Console.Write("Silmek istediğiniz TC Kimliği giriniz: ");
                            aranan = Console.ReadLine();

                            if (aranan.Length == 11 && long.TryParse(aranan, out var arananLong))
                            {
                                if (arananLong > 0)
                                {
                                    break;
                                }
                                else
                                {
                                    Kisi.HataMesaj();
                                }
                            }
                            else
                            {
                                Kisi.HataMesaj();
                            }
                        } while (true);
                        var aramaTuru = "TC";
                        Kisi.KisiSil(aramaTuru, aranan);
                    }
                }
                do
                {
                    Console.Write("Başka bir işlem daha yapmak istiyor musunuz (e/h): ");
                    var islem = Console.ReadLine().ToUpper();
                    if(islem == "E")
                    {
                        kontrol = true;
                        break;
                    }
                    else if(islem == "H")
                    {
                        Console.WriteLine("Program sonlanmıştır Bizi tercih ettiğiniz için teşekkür ederiz.");
                        break;
                    }
                    else
                    {
                        Kisi.HataMesaj();
                    }
                }while (true);
                Kisi.CizgiBas();
            } while (kontrol);
            



        }
    }
}
