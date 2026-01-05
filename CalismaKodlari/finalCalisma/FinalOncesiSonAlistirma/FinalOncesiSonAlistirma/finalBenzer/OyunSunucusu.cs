using System;
using System.Collections.Generic;
using System.Text;

namespace FinalOncesiSonAlistirma.finalBenzer
{
    internal class OyunSunucusu
    {
        public List<Karakter> AktifOyuncular;
        public OyunSunucusu()
        {
            AktifOyuncular = new List<Karakter>();
        }
        public void RastgeleOyuncuEkle(int adet)
        {
            Random rnd = new Random();

            Array siniflar = Enum.GetValues(typeof(KarakterSinifi));
            Array silahlar = Enum.GetValues(typeof(SilahTuru));

            for (int i = 0; i < adet; i++)
            {
                KarakterSinifi rastgeleSinif =
                    (KarakterSinifi)siniflar.GetValue(rnd.Next(siniflar.Length));

                SilahTuru rastgeleSilah =
                    (SilahTuru)silahlar.GetValue(rnd.Next(silahlar.Length));

                Karakter yeniKarakter = new Karakter(rastgeleSinif, rastgeleSilah);
                AktifOyuncular.Add(yeniKarakter);
            }
        }
    
    }
}
