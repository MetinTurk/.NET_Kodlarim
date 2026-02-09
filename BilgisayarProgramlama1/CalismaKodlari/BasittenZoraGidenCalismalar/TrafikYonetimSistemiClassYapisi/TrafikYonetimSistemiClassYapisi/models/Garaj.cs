using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TrafikYonetimSistemiClassYapisi.models
{
    internal class Garaj
    {
        public List<IKaraKutu> araclar = new List<IKaraKutu>();

        public void AracEkle(IKaraKutu arac)
        {
            araclar.Add(arac);
        }
    }
}
