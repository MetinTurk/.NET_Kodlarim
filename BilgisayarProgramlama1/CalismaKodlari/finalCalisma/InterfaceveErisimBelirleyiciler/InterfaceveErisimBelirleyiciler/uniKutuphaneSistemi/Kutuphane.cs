using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceveErisimBelirleyiciler.uniKutuphaneSistemi
{
        internal class Kutuphane<T> where T : Kitap
        {
            List<T> kitaplar = new List<T>();
            public void Ekle(T item) {
                kitaplar.Add(item);
            }

            public T KitapBul(string kitapAdi)
            {
                foreach (var kitap in kitaplar)
                {
                 if(kitapAdi == kitap.Ad)
                    {
                        return kitap;
                    }
                }

                return null;
            }
        }
}
