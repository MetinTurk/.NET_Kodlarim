using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Tekrari.GenericOzelVeriYapisi
{
    internal interface IDepo<T>
    {
        void Ekle(T urun);
        int StokAdedi {  get; }
    }
}
