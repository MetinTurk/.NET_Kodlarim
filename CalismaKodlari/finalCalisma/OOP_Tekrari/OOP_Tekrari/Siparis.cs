using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Tekrari
{
    internal class Siparis : TemelNesne<Guid>
    {
        public string MusteriAdi { get; set; }
        public decimal ToplamTutar { get; set; }
    }
}
