using System;
using System.Collections.Generic;
using System.Text;

namespace EsnekOdemeSistemi
{
    internal class HavaleOdeme : IOdemeYontemi
    {
        
        public void Odeme(double toplamTutar)
        {
            Console.WriteLine($"Havale ile {toplamTutar} ödendi");
        }
    }
}
