using System;
using System.Collections.Generic;
using System.Text;

namespace FinalOncesiSonAlistirma.finalBenzer
{
    internal class ArenaHasarHesaplayici: IHasarHesaplayici<double>
    {
        public double KiritikVurusSansi { get { return 15.5; } }
        public double TemelHasarHesapla(Karakter saldiran)
        {
            if(saldiran.Sinifi == KarakterSinifi.Savasci && saldiran.Silahi == SilahTuru.Kilic)
            {
                return 50;
            }
            else if (saldiran.Sinifi == KarakterSinifi.Buyucu && saldiran.Silahi == SilahTuru.Asa)
            {
                return 60;
            }
            else 
            { 
                return 10;
            }
        }
        public double KomboHasarHesapla(Karakter k1 , Karakter k2) 
        {
            double k1ToplamHasar = TemelHasarHesapla(k1);
            double k2ToplamHasar = TemelHasarHesapla(k2);
            return (k1ToplamHasar + k2ToplamHasar) * 1.2;

        }
    }
}
