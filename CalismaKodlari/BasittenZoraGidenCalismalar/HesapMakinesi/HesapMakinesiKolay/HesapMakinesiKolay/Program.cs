namespace HesapMakinesiKolay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba Hesap Makinesi Uygulamasına Hoşgeldiniz");
            char kontrol = 'h';
            do
            {
                double sayi1, sayi2;
                Console.Write("Lütfen ilk sayınızı giriniz: ");
                var sayi1String = Console.ReadLine();
                do
                {
                    if (double.TryParse(sayi1String, out sayi1))
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Hatalı giriş yaptınız Lütfen sayı giriniz: ");
                        sayi1String = Console.ReadLine();
                    }
                } while (true);
                Console.Write("Lütfen ikinci sayınızı giriniz: ");
                var sayi2String = Console.ReadLine();
                do
                {
                    if (double.TryParse(sayi2String, out sayi2))
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Hatalı giriş yaptınız Lütfen sayı giriniz: ");
                        sayi2String = Console.ReadLine();
                    }
                }while (true);
                Console.Write("1: Toplama\n2: Çıkarma\n3: Çarpma\n4: Bölme\nLütfen yapmak istediğiniz işlemi seçiniz: ");
                int secim =int.Parse(Console.ReadLine());
                if(secim == 1)
                {
                    Console.WriteLine($"Sayı 1: {sayi1} , Sayı 2 : {sayi2} , Toplamları: {sayi1} + {sayi2} = {sayi1+sayi2}");
                }
                else if (secim == 2)
                {
                    if (sayi1 >= sayi2)
                    {
                        Console.WriteLine($"Sayı 1: {sayi1} , Sayı 2 : {sayi2} , Farkları: {sayi1} - {sayi2} = {sayi1 - sayi2}");
                    }
                    else
                    {
                        Console.WriteLine($"Sayı 2: {sayi2} , Sayı 1 : {sayi1} , Farkları: {sayi2} - {sayi1} = {sayi2 - sayi1}");
                    }
                }
                else if (secim == 3)
                {
                    Console.WriteLine($"Sayı 1: {sayi1} , Sayı 2 : {sayi2} , Çarpımları: {sayi1} * {sayi2} = {sayi1 * sayi2}");
                }
                else if(secim == 4)
                {
                    if(sayi1 == 0 || sayi2 == 0)
                    {
                        Console.WriteLine("Sayı 0 a bölünemez lütfen tekrar deneyin");
                    }
                    else
                    {
                        Console.WriteLine($"Sayı 1: {sayi1} , Sayı 2 : {sayi2} , Bölümü: {sayi1} / {sayi2} = {sayi1 / sayi2}");
                    }
                }
                else
                {
                    Console.WriteLine("Yanlış seçim yaptınız lütfen tekrar deneyiniz.");
                }
                    Console.Write("Tekrar işlem yapmak ister misiniz (e/h): ");
                kontrol = char.Parse(Console.ReadLine().ToUpper());
                Console.WriteLine("---------------------------------------");
            } while (kontrol == 'E');
            Console.WriteLine("Bizi tercih ettiğiniz için teşekkür ederiz.");
        }
    }
}
