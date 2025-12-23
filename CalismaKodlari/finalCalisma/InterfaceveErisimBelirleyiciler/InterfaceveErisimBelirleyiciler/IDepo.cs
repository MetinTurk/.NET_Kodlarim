using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceveErisimBelirleyiciler
{
    internal interface IDepo<T> where T : IUrun
    {
        void Ekle(T Urun);
        List<T> TumunuGetir();
    }
}
