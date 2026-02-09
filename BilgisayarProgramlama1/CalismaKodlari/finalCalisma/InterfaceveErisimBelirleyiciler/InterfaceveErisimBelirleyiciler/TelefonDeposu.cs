using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceveErisimBelirleyiciler
{
    internal class TelefonDeposu : Depo<Telefon>, ITelefonDeposu
    {
        public Telefon GetirByImei(string imeiNo)
        {
            foreach (var urun in Urunler)
            {
                Console.WriteLine(urun.UrunAdi);
            }
            return null;
        }

        
    }
}
