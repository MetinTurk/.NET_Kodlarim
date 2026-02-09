using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceveErisimBelirleyiciler
{
    public abstract class BaseUrun : IUrun
    {
        public string UrunAdi { get; set; }

        public decimal Fiyat { get; set; }

        public abstract void StokDus(int adet);

        public virtual decimal KdvHesapla()
        {
            return this.Fiyat * 1.20M;
        }
    }
}
