using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceveErisimBelirleyiciler
{
    public interface IUrun
    {
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; }
        public void StokDus(int adet);




    }
}
