using System;
using System.Collections.Generic;
using System.Text;

namespace EsnekOdemeSistemi
{
    internal class KrediKartiOdeme : IOdemeYontemi
    {
        
        public void Odeme(double toplamTutar)
        {
            Console.WriteLine($"Kredi Kartı ile {toplamTutar * 1.1} ödendi");
        }
    }
}
