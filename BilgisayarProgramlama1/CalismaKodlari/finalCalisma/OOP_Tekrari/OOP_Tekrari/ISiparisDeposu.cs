using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Tekrari
{
    internal interface ISiparisDeposu : IVeriDeposu<Siparis,Guid>
    {
        List<Siparis> MusteriSiparisleriniGetir(string musteriAdi);
        
    }
}
