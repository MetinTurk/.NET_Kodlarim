namespace InterfaceveErisimBelirleyiciler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            
            Console.WriteLine(UsAl(5));

            Console.WriteLine(TersCevir("merhaba"));
            //tersine çevirme fonsk kullanımı
        }


        public static int UsAl(int kuvvet)
        {
            if (kuvvet == 0)
            {
                return 1;
            }
            return 2 * UsAl(kuvvet - 1);
        }




        public static string TersCevir(string kelime)
        {
            
            if(kelime.Length <= 1)
            {
                return kelime;
            }
            return kelime[kelime.Length-1] + TersCevir(kelime.Substring(0, kelime.Length - 1));
        }
    }
}
