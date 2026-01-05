using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Tekrari.PistiOyunu
{
    internal class El
    {
        private bool[] oynadiMi;

        public Kart[] Kartlar { get; }
        public El(Kart k1, Kart k2, Kart k3, Kart k4)
        {
            Kartlar[0] = k1;    
            Kartlar[1] = k2;    
            Kartlar[2] = k3;    
            Kartlar[3] = k4;
            oynadiMi = new bool[4];
        }
        public bool OynadiMi(int index)
        {
            return oynadiMi[index];
        }

        public Kart Oyna(int index)
        {
            if(index > 3)
            {
                throw new HataliKart("Hatali Kart seçildi");
            }
            if (OynadiMi(index))
            {
                throw new Exception("Bu kart daha önce oynanmış");
            }
            oynadiMi[index] = true;
            return Kartlar[index];
        }
    }
}
