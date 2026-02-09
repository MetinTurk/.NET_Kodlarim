namespace SayiTahminUygulamasiKolay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tahmin,  hak = 7;
            Console.WriteLine("Sayi Tahmin Oyununa Hoşgeldiniz");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Toplam Hakkınız : {hak}");
            var rand = new Random();
            int randomSayi = rand.Next(1, 100);
            do
            {
                Console.Write("Lütfen tahmininizi giriniz (1,100): ");
                var tahminString = Console.ReadLine();
                do
                {
                    if(int.TryParse(tahminString, out tahmin))
                    {
                        if(tahmin > 0)
                        {
                            if (tahmin < 100)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Lütfen 100 den büyük sayı girmeyiniz");
                                Console.Write("Lütfen tahmininizi giriniz (1 , 100): ");
                                tahminString = Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Lütfen negatif sayı girmeyiniz");
                            Console.Write("Lütfen tahmininizi giriniz (1 , 100): ");
                            tahminString = Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.Write("Lütfen sayı giriniz: ");
                        tahminString = Console.ReadLine();
                    }
                } while (true);
                hak--;
                if(tahmin > randomSayi)
                {
                    Console.WriteLine("Tahmininiz tutulan sayıdan büyük");
                    Console.WriteLine($"Kalan hakkınız: {hak}");
                }
                else if(tahmin < randomSayi)
                {
                    Console.WriteLine("Tahmininiz tutulan sayıdan küçük");
                    Console.WriteLine($"Kalan hakkınız: {hak}");
                }
                else
                {
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("Tahmininiz Doğru");
                    Console.WriteLine("KAZANDINIZ");
                    Console.WriteLine($"{7-hak}. tahminde bildiniz");
                    break;
                }

            } while (true);
        }
    }
}
