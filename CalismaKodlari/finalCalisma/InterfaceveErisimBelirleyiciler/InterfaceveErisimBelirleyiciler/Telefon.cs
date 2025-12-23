using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceveErisimBelirleyiciler
{
    internal class Telefon : BaseUrun
    {

        public override void StokDus(int adet)
        {
            Console.WriteLine($"{adet} adet telefon stoğu düşüldü.");
        }

        public override decimal KdvHesapla()
        {
            return this.Fiyat * 1.5M;
        }
    }
}
