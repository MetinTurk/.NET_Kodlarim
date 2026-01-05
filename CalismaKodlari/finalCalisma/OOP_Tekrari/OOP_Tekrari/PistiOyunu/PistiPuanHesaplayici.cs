using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Tekrari.PistiOyunu
{
    internal class PistiPuanHesaplayici: IPuanHesaplayici<int>
    {
        public int KagitFazlasiPuan 
        { get
            {
                return 3;
            }
        }
        public int PistiPuanHesapla(Kart kart1 , Kart kart2)
        {
            if(kart1.KartTuru == KartTur.Vale && kart2.KartTuru == KartTur.Vale)
            {
                return 20;
            }
            else
            {
                return 10;
            }
        }
        public int NormalKartPuanHesapla(Kart[] kartlar)
        {
            int toplamPuan =0;
            foreach (var kart in kartlar)
            {
                if(kart.KartTuru == KartTur.As || kart.KartTuru == KartTur.Vale)
                {
                    toplamPuan++;
                }
                else if(kart.KartTuru == KartTur.Iki && kart.Simgesi == Simge.Sinek)
                {
                    toplamPuan += 2;
                }
                else if(kart.Simgesi == Simge.Karo && kart.KartTuru == KartTur.On)
                {
                    toplamPuan += 3;
                }
            }
            return toplamPuan;
        }
    }
}
