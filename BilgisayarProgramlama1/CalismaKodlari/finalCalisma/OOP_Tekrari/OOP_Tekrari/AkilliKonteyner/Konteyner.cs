using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Tekrari.AkilliKonteyner
{
    internal class Konteyner<T> where T : IYuk , new()
    {
        T[] _yukler;
        public Konteyner(int kapasite)
        {
            if (kapasite < 1) kapasite = 4;
            _yukler = new T[kapasite];
        }
        void Yukle(T yuk)
        {
            if(yuk.Agirlik >= 100)
            {
                throw new AgirlikHatasi("Ağırlık 100 kg den fazla");
            }
            bool kontrol = false;
            for (int i = 0; i < _yukler.Length; i++)
            {
                if (_yukler[i] == null)
                {
                    _yukler[i] = yuk;
                    kontrol = true;
                    break;
                }
            }
            if (!kontrol)
            {
                int kapasite = _yukler.Length;
                T[] yeniYukler = new T[kapasite*2];
                Array.Copy(_yukler, yeniYukler, kapasite);
                _yukler = yeniYukler;
                _yukler[kapasite] = yuk;
            }
        }
        T Bosalt()
        {
            if (_yukler[0] == null)
            {
                return default(T);
            }
            
            for (int i = 0; i < _yukler.Length; i++)
            {
                if (_yukler[i] == null)
                {
                    T silinecek = _yukler[i - 1];
                    _yukler[i - 1] = default(T);
                    return silinecek;
                    break;
                }
            }
            T enSonYuk = _yukler[_yukler.Length - 1];
            _yukler[_yukler.Length - 1] = default(T);
            return enSonYuk;
        }

        int ToplamAgirlik()
        {
            int toplam = 0;
            for (int i = 0; i < _yukler.Length; i++)
            {
                if (_yukler[i] != null)
                {
                    toplam += _yukler[i].Agirlik;
                }
            }
            return toplam;
        }
    }
}
