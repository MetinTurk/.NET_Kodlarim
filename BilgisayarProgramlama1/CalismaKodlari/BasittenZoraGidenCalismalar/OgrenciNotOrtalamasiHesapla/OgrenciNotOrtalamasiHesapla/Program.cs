namespace OgrenciNotOrtalamasiHesapla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Öğrenci Not Ortalaması Hesaplama Otomasyonuna Hoşgeldiniz.");
            Dictionary<string, double> dict = new Dictionary<string, double>();
            bool kontrol;
            do
            {
                Console.Write("Notunu girmek istediğiniz öğrencinin ismini giriniz: ");
                var isim = Console.ReadLine();
                
                int not;
                do
                {
                    Console.Write("Notunu giriniz: ");
                    var notString = Console.ReadLine();
                    if (int.TryParse(notString, out not))
                    {                       
                        if(not >= 0 && not <= 100)
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hatalı not girişi");                        
                    }

                } while (true);
                dict.Add(isim, not);
                do
                {
                    Console.Write("Bir öğrenci notu daha girmek istiyor musunuz (e/h): ");
                    var tekrar = Console.ReadLine().ToUpper();
                    if (tekrar == "E" || tekrar == "H")
                    {
                        if (!(tekrar == "E"))
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
            double toplam = 0.0;
            foreach (var item in dict.Values)
            {
                toplam += item;
            }
            /*
            Console.WriteLine($"{dict.Keys.Max()}");            //Burada sadece en büyük notun sayısal değerini bulabiliyorduk.
            List<string> liste_isimler = dict.Keys.ToList();
            List<double> liste_notlar = dict.Values.ToList();
            */
            double enBuyuk = 0;
            foreach (var item in dict)
            {
                if(item.Value > enBuyuk)
                {
                    enBuyuk = double.Parse(item.Value.ToString());
                }
            }
            foreach (var item in dict)
            {
                if(item.Value == enBuyuk)
                {
                    Console.WriteLine($"Tebrikler {item.Key}. En yüksek not: {item.Value}");
                }
            }


            Console.WriteLine($"Sınıf ortalaması: {toplam / dict.Count()}"); 
        }
        
    }
    
    

}
