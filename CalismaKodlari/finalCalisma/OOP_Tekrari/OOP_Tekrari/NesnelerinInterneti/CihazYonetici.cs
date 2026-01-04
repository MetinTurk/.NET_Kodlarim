using System;
using System.Collections.Generic;
using System.Runtime;
using System.Text;

namespace OOP_Tekrari.NesnelerinInterneti
{
    internal class CihazYonetici<T> where T : AkilliCihaz , new()
    {
        T[] cihazlar;
        public CihazYonetici(int kapasite)
        {
            cihazlar = new T[kapasite];
        }
        void Ekle(T cihaz)
        {
            bool kontrol = false;
            for (int i = 0; i < cihazlar.Length; i++)
            {
                if (cihazlar[i] == null)
                {
                    cihazlar[i] = cihaz;
                    kontrol = true;
                    break;
                }
            }
            if (!kontrol)
            {
                T[] yeniCihazlar = new T[cihazlar.Length * 2];
                for (int i = 0; i < cihazlar.Length; i++)
                {
                    yeniCihazlar[i] = cihazlar[i];
                }
                yeniCihazlar[cihazlar.Length] = cihaz;
                cihazlar = yeniCihazlar;
            }
        }
        public void TumunuKapat()
        {
            for (int i = 0; i < cihazlar.Length; i++)
            {
                if (cihazlar[i] != null)
                {
                    cihazlar[i].AcikMi = false;
                }
            }
        }

        public int AktifCihazSayisi 
        { get 
            {
                int toplam = 0;
                for (int i = 0; i < cihazlar.Length; i++)
                {
                    if (cihazlar[i].AcikMi)
                    {
                        toplam++;
                    }
                }
                return toplam;
            } 
        }
    }
}
