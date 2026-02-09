using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Tekrari.MuzikPlatformu
{
    internal class CalmaListesi<TNesne , TId> where TNesne: MedyaOgesi<TId>
    {
        List<TNesne> calmaListesi;
        public CalmaListesi()
        {
            calmaListesi = new List<TNesne>();
        }

        public void Ekle(TNesne eklenecekVeri)
        {
            foreach (var item in calmaListesi)
            {
                if(item.Id.Equals(eklenecekVeri.Id))
                {
                    throw new VeriEklemeHatasi("Ekleyeceğiniz veri listede vardır.");
                }
            }
            calmaListesi.Add(eklenecekVeri);
        }

        public double ToplamSure 
        { 

            get
            {
                double toplam = 0;
                foreach (var item in calmaListesi)
                {
                    toplam += item.Sure;
                }
                return toplam;
            }
        }
        public void Karistir()
        {
            this.calmaListesi.Shuffle();
        }

    }
}
