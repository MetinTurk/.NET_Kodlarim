namespace BankaHesabi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Banka otomasyonuna Hoşgeldiniz.");
            int secim;
            Console.Write("Lütfen hesap bilgilerinizi giriniz: ");
            string hesapBilgisi = Console.ReadLine();
            Banka bank = new Banka(hesapBilgisi);
            string kontrol;
            do
            {
                
                do
                {
                    Console.Write("1-) Para Yatır\n2-) Para Çek\nLütfen yapacağınız işlemi seçiniz: ");
                    var secimString = Console.ReadLine();
                    if (int.TryParse(secimString, out secim))
                    {
                        if(secim > 0 && secim < 3)
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hatalı tuşlama yaptınız.");
                    }
                } while (true);
                if(secim == 1)
                {
                    bank.ParaYatir();
                }
                else if(secim == 2)
                {
                    bank.ParaCek();
                }
                Console.Write("Başka bir işlem yapmak istiyor musunuz (e/h) ? ");
                kontrol = Console.ReadLine().ToUpper();
            } while (kontrol == "E");

            

        }
    }
}
