using System.Reflection;

namespace OOP_To_Do_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yapılacaklar Listesi Otomasyonuna Hoşgeldiniz.");
            int secim;
            List<Gorev> liste = new List<Gorev>();
            bool kontrol;
            bool listeBosMU;
            do
            {
                do
                {
                    Console.Write("1-) Görev Ekle\n2-) Görev Listele\n3-) Görev Tamamla\n4-) Görev Güncelle\n5-) Görev Sil\nLütfen yapacağınız işlemi seçiniz: ");
                    var secimString = Console.ReadLine();
                    if ((int.TryParse(secimString, out secim)) && secim > 0 && secim < 6)
                    {
                        if (secim == 1)
                        {
                            Console.Write("Eklemek istediğiniz görevi yazınız: ");
                            var gorev = Console.ReadLine();
                            Gorev g = new Gorev(gorev);
                            liste.Add(g);
                        }
                        else if (secim == 2)
                        {
                            listeBosMU = Gorev.EkranaYaz(liste);
                        }
                            
                        else if(secim == 3)
                        {
                            listeBosMU = Gorev.EkranaYaz(liste);
                            if (listeBosMU)
                            {
                                int secilen;
                                do
                                {
                                    Console.Write("Hangi görevi tamamlamak istiyorsunuz: ");
                                    var secilenString = Console.ReadLine();
                                    if (int.TryParse(secilenString, out secilen) && secilen < liste.Count())
                                    {
                                        liste[secilen - 1].Durum = true;
                                        Console.WriteLine("Görevinizi tamamladığınız için teşekkürler.");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Yanlış tuşlama yaptınız Lütfen Tekrar deneyiniz.");
                                        Console.WriteLine("-----------------------------------------------------");
                                    }
                                } while (true);
                            }
                            
                        }
                        else if (secim == 4)
                        {
                            listeBosMU =  Gorev.EkranaYaz(liste);
                            if (listeBosMU)
                            {
                                int secilen;
                                do
                                {
                                    Console.Write("Hangi görevi güncellemek istiyorsunuz: ");
                                    var secilenString = Console.ReadLine();
                                    if (int.TryParse(secilenString, out secilen) && secilen < liste.Count())
                                    {
                                        liste.RemoveAt(secilen - 1);
                                        Console.Write("Görevinizin güncel halini yazınız: ");
                                        var gorev = Console.ReadLine();
                                        Gorev g = new Gorev(gorev);
                                        liste.Add(g);
                                        liste.Insert(secilen, g);
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Yanlış tuşlama yaptınız Lütfen Tekrar deneyiniz.");
                                        Console.WriteLine("-----------------------------------------------------");
                                    }
                                } while (true);
                            }
                            
                        }
                        else if (secim == 5)
                        {
                            listeBosMU = Gorev.EkranaYaz(liste);
                            if (listeBosMU) {
                                int secilen;
                                do
                                {
                                    Console.Write("Hangi görevi silmek istiyorsunuz: ");
                                    var secilenString = Console.ReadLine();
                                    if (int.TryParse(secilenString, out secilen) && secilen < liste.Count())
                                    {
                                        liste.RemoveAt(secilen - 1);
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Yanlış tuşlama yaptınız Lütfen Tekrar deneyiniz.");
                                        Console.WriteLine("-----------------------------------------------------");
                                    }
                                } while (true);
                            }
                            
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Yanlış tuşlama yaptınız Lütfen Tekrar deneyiniz.");
                        Console.WriteLine("-----------------------------------------------------");
                    }
                } while (true);
                do
                {
                    Console.Write("Tekrar işlem yapmak ister misiniz (e/h): ");
                    var kontrolStr = Console.ReadLine().ToUpper();
                    if (kontrolStr == "E" || kontrolStr == "H")
                    {
                        if (!(kontrolStr == "E"))
                        {
                            kontrol = false;
                            break;
                        }
                        else
                        {
                            kontrol = true;
                            break;
                        }
                    }

                } while (true);
                Gorev.CizgiBas();

            } while (kontrol);
            Console.WriteLine("Bizi tercih ettiğiniz için teşekkür ederiz.");
        }
    }
}
