using TrafikYonetimSistemiClassYapisi.models;

namespace TrafikYonetimSistemiClassYapisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Otomobil otomobil = new Otomobil("26 DC 724");
            PolisAraci polisAraci = new PolisAraci("26 AB 566", "Organize");
            PolisAraci polisAraciNarkotik = new PolisAraci("26 AB 854", "Narkotik");
            Console.WriteLine(PolisAraci.polisAraciSayisi);
            Console.WriteLine("----------------------------");
            Garaj garaj = new Garaj();
            garaj.AracEkle(polisAraci);
            garaj.AracEkle(polisAraciNarkotik);
            //garaj.AracEkle(otomobil);     //Hata : IKaraKutu implemente etmiyor.

            try
            {
                polisAraci.Hiz = 120;
                Console.WriteLine("Şuanki hız: " + polisAraci.Hiz);

                polisAraci.Hiz = 300;
            }
            catch (HizSinirlarAsildi ex)
            {
                Console.WriteLine("Hata yakalandı: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Genel bir hata : " + ex.Message);
            }
        }
    }
}
