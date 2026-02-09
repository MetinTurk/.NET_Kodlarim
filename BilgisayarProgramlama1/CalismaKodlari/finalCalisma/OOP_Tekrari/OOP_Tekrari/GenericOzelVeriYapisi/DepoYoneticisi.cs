using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Tekrari.GenericOzelVeriYapisi
{
    internal class DepoYoneticisi<T> : IDepo<T> where T : class, new()
    {
        public void Ekle(T urun)
        {
            bool kontrol = false;
            for (int i = 0; i < _urunler.Length; i++)
            {
                if (_urunler[i] == null)
                {
                    _urunler[i] = urun;
                    kontrol = true;
                    _dolulukOrani++;
                    break;
                }
            }
            if (!kontrol)
            {
                KapasiteArttir();
                for (int i = 0; i < _urunler.Length; i++)
                {
                    if (_urunler[i] == null)
                    {
                        _urunler[i] = urun;
                        _dolulukOrani++;
                    } 
                }
            }
        }
        private void KapasiteArttir()
        {
            T[] yeniElemanlar = new T[_urunler.Length*2];
            Array.Copy(_urunler, yeniElemanlar, _urunler.Length);
            _urunler = yeniElemanlar;
        }

        public int StokAdedi { get { return _dolulukOrani; } }

        private T[] _urunler;
        private int _dolulukOrani;
        public DepoYoneticisi(int kapasite)
        {
            if (kapasite < 5)
            {
                kapasite = 5;
                _urunler = new T[kapasite];
            }
        }
    }
}
