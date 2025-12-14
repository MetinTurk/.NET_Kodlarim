using System;
using System.Collections.Generic;
using System.Text;

namespace TrafikYonetimSistemiClassYapisi.models
{
    internal class PolisAraci : ResmiArac, IKaraKutu
    {
        public static int polisAraciSayisi = 0;
        public PolisAraci(string plaka, string kurumAdi) : base(plaka, kurumAdi)
        {
            polisAraciSayisi++;
        }

        public string KaraKutu { get; set; }

        public void VeriyiKaydet()
        {
            throw new NotImplementedException();
        }

        public override void MotoruCalistir()
        {
            Console.WriteLine("Yüksek performanslı motor ve sirenler aktif");
        }
    }
}
