namespace BasicTo_Do_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Yapılacaklar Listesi Otomasyonuna Hoşgeldiniz.");
            int secim;
            List<String> liste = new List<String>();
            bool kontrol;
            do
            {
                do
                {
                    Console.Write("1-) Görev Ekle\n2-) Görev Listele\n3-) Görev Güncelle\n4-) Görev Sil\nLütfen yapacağınız işlemi seçiniz: ");
                    var secimString = Console.ReadLine();
                    if ((int.TryParse(secimString, out secim)) && secim > 0 && secim < 5)
                    {
                        if (secim == 1)
                        {
                            Console.Write("Eklemek istediğiniz görevi yazınız: ");
                            var gorev = Console.ReadLine();
                            liste.Add(gorev);
                        }
                        else if (secim == 2)
                        {
                            var i = 0;
                            foreach (var item in liste)
                            {
                                i++;
                                Console.WriteLine($"{i}. Görev : {item}");
                            }
                        }
                        else if (secim == 3)
                        {
                            var i = 0;
                            foreach (var item in liste)
                            {
                                i++;
                                Console.WriteLine($"{i}. Görev : {item}");
                            }
                            int secilen;
                            do
                            {
                                Console.Write("Hangi görevi güncellemek istiyorsunuz: ");
                                var secilenString = Console.ReadLine();
                                if (int.TryParse(secilenString, out secilen) && secilen < liste.Count())
                                {
                                    liste.RemoveAt(secilen-1);
                                    Console.Write("Görevinizin güncel halini yazınız: ");
                                    var gorev = Console.ReadLine();
                                    liste.Insert(secilen, gorev);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Yanlış tuşlama yaptınız Lütfen Tekrar deneyiniz.");
                                    Console.WriteLine("-----------------------------------------------------");
                                }
                            } while (true);
                        }
                        else if (secim == 4)
                        {
                            var i = 0;
                            foreach (var item in liste)
                            {
                                i++;
                                Console.WriteLine($"{i}. Görev : {item}");
                            }
                            int secilen;
                            do
                            {
                                Console.Write("Hangi görevi silmek istiyorsunuz: ");
                                var secilenString = Console.ReadLine();
                                if (int.TryParse(secilenString, out secilen) && secilen < liste.Count())
                                {
                                    liste.RemoveAt(secilen-1);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Yanlış tuşlama yaptınız Lütfen Tekrar deneyiniz.");
                                    Console.WriteLine("-----------------------------------------------------");
                                }
                            } while (true);
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
                        if(!(kontrolStr == "E"))
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
                
            } while (kontrol);
            Console.WriteLine("Bizi tercih ettiğiniz için teşekkür ederiz.");
            
            

        }
    }
}
