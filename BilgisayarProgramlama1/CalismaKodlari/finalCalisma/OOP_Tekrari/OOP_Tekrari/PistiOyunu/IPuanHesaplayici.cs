using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Tekrari.PistiOyunu
{
    internal interface IPuanHesaplayici<T>
    {
        T NormalKartPuanHesapla(Kart[] kartlar);
        T PistiPuanHesapla(Kart kart1 , Kart kart2);
        public T KagitFazlasiPuan { get; }
    }
}
