using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Tekrari.PistiOyunu
{
    internal class Kart
    {
        private static Dictionary<KartTur, string> kartAdlari = new Dictionary<KartTur, string>();
        private static Dictionary<Simge, string> simgeAdlari = new Dictionary<Simge, string>();
        public Simge Simgesi { get; }
        public KartTur KartTuru { get; }
        public Kart(Simge simge , KartTur kartTur)
        {
            this.Simgesi = simge;
            this.KartTuru = kartTur;
        }
        

        public override string ToString()
        {
            return $"{simgeAdlari[Simgesi]} {kartAdlari[KartTuru]}";
        }

    }
}
