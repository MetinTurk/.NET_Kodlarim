using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Tekrari
{
    internal sealed class Liste<T> : IListe<T> where T : class
    {
        private const int VarsayilanKapasite = 4;
        private T[] _elemanlar;
        private int _boyut;
        public Liste()
        {
            _elemanlar = new T[0];
        }
        public Liste(int kapasite)
        {
            if(kapasite < 0)
            {
                kapasite = 0;
            }
            _elemanlar = new T[kapasite];

        }
        public int ElemanSayisi { get { return _boyut; } }

        public void Ekle(T item)
        {
            if(_boyut == _elemanlar.Length)
            {
                KapasiteKontrolEt(_boyut+1);
                _elemanlar[_boyut] = item;
                _boyut++;
            }
        }

        public int Kapasite
        {
            get { return _elemanlar.Length; }
            set { if (value == _elemanlar.Length) 
                    {
                        return;
                    }
                else if(value < 0)
                {
                    _elemanlar = new T[0];
                }
                else
                {
                    T[] yeniElemanlar = new T[value];
                    if(this._boyut >  0)
                    {
                        int kopyalanacakAdet = (_boyut > value) ? value : _boyut;
                        Array.Copy(_elemanlar , yeniElemanlar , kopyalanacakAdet);
                    }
                    _elemanlar = yeniElemanlar;
                }
            }
        }

        private void KapasiteKontrolEt(int yeniBoyut)
        {
            if(_elemanlar.Length < yeniBoyut)
            {
                int yeniKapasite;
                if (_elemanlar.Length == 0)
                {
                     yeniKapasite = VarsayilanKapasite;
                }
                else
                {
                     yeniKapasite = _elemanlar.Length*2;
                }
                Kapasite = yeniKapasite;
            }
        }
    }
}
