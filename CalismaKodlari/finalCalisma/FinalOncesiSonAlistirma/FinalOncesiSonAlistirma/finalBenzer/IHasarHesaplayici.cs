using System;
using System.Collections.Generic;
using System.Text;

namespace FinalOncesiSonAlistirma.finalBenzer
{
    internal interface IHasarHesaplayici<T>
    {
        T KiritikVurusSansi { get; }
        T TemelHasarHesapla(Karakter saldiran);
        T KomboHasarHesapla(Karakter k1, Karakter k2);
    }
}
