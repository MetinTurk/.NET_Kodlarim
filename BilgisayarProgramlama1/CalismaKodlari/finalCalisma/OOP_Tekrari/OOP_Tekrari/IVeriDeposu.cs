using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Tekrari
{
    internal interface IVeriDeposu<TNesne , TId> where TNesne : IKayitNesnesi<TId> , new()
    {
        void Ekle(TNesne n);
        TNesne Getir(TId Id);
        bool Sil(TId Id);
    }
}
