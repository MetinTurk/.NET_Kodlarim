using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Tekrari
{
    internal class Deste<T> where T : IKart , new()
    {
        T[] kartlar;
        public Deste(int kapasite)
        {
            kartlar = new T[kapasite];
        }

        void KartEkle(T kart)
        {
            bool kontrol  = false;
            for (int i = 0; i < kartlar.Length; i++)
            {
                if (kartlar[i] == null)
                {
                    kartlar[i] = kart;
                    kontrol = true;
                    break;
                }
            }
            if (!kontrol)
            {
                T[] yeniKartlar = new T[kartlar.Length*2];
                Array.Copy(kartlar, yeniKartlar, kartlar.Length);
                kartlar = yeniKartlar;
                KartEkle(kart);
            }
        }

        public T KartCek()
        {
            if (kartlar[0] == null)
            {
                return default(T);  
            }

            for (int i = 0; i < kartlar.Length; i++)
            {   
                if (kartlar[i] == null )
                {
                    T donucekKart = kartlar[i - 1];
                    kartlar[i - 1] = default(T);
                    return donucekKart;
                }
                
            }
            T donucekKart2 = kartlar[kartlar.Length-1];
            kartlar[kartlar.Length-1] = default(T);
            return donucekKart2;

        }
    }
}
