using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTicaretOtomasyonu
{
    internal class Sepet
    {
        List<Urun> sepet = new List<Urun>();
        public Sepet()
        {
            
        }

        public void UrunEkle(Urun urun)
        {
            sepet.Add(urun);
            Console.WriteLine("Ürün sepete eklendi.");
        }

        public void UrunlerGoster()
        {
            int sayac = 1;
            foreach (var item in sepet)
            {
                Console.Write($"{sayac} . ürün : ");
                item.BilgileriGoster();
                sayac++;
            }
        }

        public double ToplamTutarHesapla()
        {
            double toplam = 0;
            foreach (var item in sepet)
            {
                toplam += item.FiyatHesapla();
            }
            return toplam;
        }


    }
}
