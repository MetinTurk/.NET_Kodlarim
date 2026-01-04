using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Tekrari
{
    internal class SiparisDeposu: TemelDepo<Siparis , Guid> , ISiparisDeposu
    {
        //bunda hata veriyor.
        public List<Siparis> MusteriSiparisleriniGetir(string musteriAdi)
        {
            throw new NotImplementedException();      //bunu kabul etmiyor.
        }
        /*
        public List<Siparis> ISiparisDeposu.MusteriSiparisleriniGetir(string musteriAdi)
        {
            return MusteriSiparisleriniGetir(musteriAdi);
        }
        */
    }
}
