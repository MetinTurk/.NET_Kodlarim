using System;
using System.Collections.Generic;
using System.Text;

namespace FinalOncesiSonAlistirma.finalBenzer
{
    internal class Takim
    {
        public bool[] yasiyorMu;
        public Karakter[] Uyeler { get; private set; }
        public Takim(Karakter karakter1, Karakter karakter2, Karakter karakter3)
        {
            Uyeler = new Karakter[3];
            yasiyorMu = new bool[3];
            Uyeler[0] = karakter1;
            Uyeler[1] = karakter2;
            Uyeler[2] = karakter3;
            for (int i = 0; i < 3; i++)
            {
                yasiyorMu[i] = true;
            }
        }
        public Karakter SalidiriyaGonder(int index)
        {
            if(index<0 || index > 2)
            {
                throw new Exception("Geçersiz uye seçimi");
            }
            if (!yasiyorMu[index])
            {
                throw new Exception("Bu karakter baygın saldıramaz!");
            }
            return Uyeler[index];
        }
    }

}
