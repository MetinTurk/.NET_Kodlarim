using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Tekrari
{
    internal interface IListe<T> where T : class
    {
        public int ElemanSayisi { get; }
        void Ekle(T veri);
    }
}
