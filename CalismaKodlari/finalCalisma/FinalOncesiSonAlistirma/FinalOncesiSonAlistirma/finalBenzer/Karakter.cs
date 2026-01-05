using System;
using System.Collections.Generic;
using System.Text;

namespace FinalOncesiSonAlistirma.finalBenzer
{
    internal class Karakter
    {
        public static Dictionary<KarakterSinifi,string> sinifAciklamalari = new Dictionary<KarakterSinifi,string>();
        public KarakterSinifi Sinifi { get; }
        public SilahTuru Silahi { get; }

        public Karakter(KarakterSinifi sinif , SilahTuru silah)
        {
            this.Silahi = silah;
            this.Sinifi = sinif;
        }

        public override string ToString()
        {
            return $"Karakter: {Sinifi} {sinifAciklamalari[Sinifi]} - Ekipman: {Silahi} ";
        }
    }
}
