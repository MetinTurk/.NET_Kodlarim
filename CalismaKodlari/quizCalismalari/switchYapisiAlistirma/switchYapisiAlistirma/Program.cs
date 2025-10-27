namespace switchYapisiAlistirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write($"Kargonuzun agirligini giriniz: ");
            //int agirlik = int.Parse(Console.ReadLine());
            //Console.Write($"Kargonuzu göndereceğiniz bolgeyi seciniz (A/B/C): ");
            //char bolgeKodu = char.Parse(Console.ReadLine());

            //int kargoUcreti = (agirlik,bolgeKodu) switch
            //{
            //    (>= 0 and < 5, 'A') => kargoUcreti = 25,
            //    (>=5 , 'A') => kargoUcreti = 40,
            //    (>= 0 and <10 , 'B') => kargoUcreti = 35,
            //    (>= 10 and <20 , 'B') => kargoUcreti = 55,
            //    (>= 20 , 'B') => kargoUcreti = 75,
            //    (>= 0 , 'C') => kargoUcreti = 100,
            //    _ => kargoUcreti = 0
            //};
            //Console.WriteLine($"Kargo Ücretiniz: {kargoUcreti}");

            /*
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    if(j == 3)
                    {
                        Console.WriteLine("Özel denetim");
                        continue;
                    }
                    if(i > 2 && j > 7)
                    {
                        Console.WriteLine("Arızalı ürün");
                        break;
                    }
                    Console.WriteLine($"{i}");
                }
            }
            */

            /*
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if(i >= j)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
            */
            int satir = 5;
            int sutun = 9;
            for (int i = 1; i <= satir; i++)
            {
                for (int j = i; j < satir; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k  <= ((2*i) - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
