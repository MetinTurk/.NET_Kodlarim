

namespace Hafta11Pazartesi.Models
{
    internal class Patron : Yonetici
    {
        public void TunPersoneliCalistir(Calisan[] calisanlar)
        {
            for (int i = 0; i < calisanlar.Length; i++)
            {
                var seciliCalisan = calisanlar[i];

                //run time type identification
                if(seciliCalisan is Yonetici)
                {
                    (seciliCalisan as Yonetici).BirimiYonet();

                    //cast
                    ((Yonetici) seciliCalisan).BirimiYonet();
                }
                var patron = seciliCalisan as Patron;
                if(patron is not null)
                {
                    patron.CalisanlaraYemekIsmarla();
                }

                if(seciliCalisan is not null)
                {
                    seciliCalisan.Calis();
                }
                
            }
        }
        //sadece calisan kişiler yemek yiyebilir.
        public void CalisanlaraYemekIsmarla(IKisi[] calisanlar)
        {
            for (int i = 0; i < calisanlar.Length; i++)
            {
                Console.WriteLine("Afiyet Olsun");
            }
        }
        public void CalisanlaraYemekIsmarla()
        {
            Console.WriteLine("Afiyet Olsun");
        }

    }
}
