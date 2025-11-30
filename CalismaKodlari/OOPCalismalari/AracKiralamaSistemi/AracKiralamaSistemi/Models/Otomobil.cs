using System;
using System.Collections.Generic;
using System.Text;

namespace AracKiralamaSistemi.Models
{
    internal class Otomobil : Tasit
    {
        public int KapiSayisi { get; set; }
        public Otomobil(string Marka, string Model, decimal GunlukUcret,int KapiSayisi) : base(Marka, Model, GunlukUcret)
        {
            this.KapiSayisi = KapiSayisi;
        }

        public override decimal KiraBedeliHesapla(int gunSayisi)
        {
            if (gunSayisi > 30)
                return (this.GunlukUcret * gunSayisi) * 0.8M;
            else
                return base.KiraBedeliHesapla(gunSayisi);
        }
    }
}
