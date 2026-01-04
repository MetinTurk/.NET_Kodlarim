using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Tekrari
{
    internal abstract class TemelDepo<TNesne,TId> : IVeriDeposu<TNesne,TId> where TNesne : IKayitNesnesi<TId> , new()
    {
        public void Ekle(TNesne Nesne)
        {
            throw new NotImplementedException();
        }
        public TNesne Getir(TId Id)
        {
            throw new NotImplementedException();
        }
        public bool Sil(TId Id)
        {
            throw new NotImplementedException(); 
        }
    }
}
