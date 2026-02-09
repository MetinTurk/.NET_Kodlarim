using System;
using System.Collections.Generic;
using System.Text;

namespace AracKiralamaSistemi.Models
{
    internal class Tasit
    {
        public string Marka { get; }
        public string Model { get; }
        private decimal _gunlukUcret;

        public decimal GunlukUcret
        {
            get { return _gunlukUcret; }
            set 
            {
                if (value < 0)
                {
                    _gunlukUcret = 100;
                }
                else
                {
                    _gunlukUcret = value;
                }
            }
        }
        public Tasit(string Marka , string Model , decimal GunlukUcret)
        {
            this.Marka = Marka;
            this.Model = Model;
            this.GunlukUcret = GunlukUcret;
        }

        public string BilgiYazdir()
        {
            return $"Marka: {this.Marka}, Model: {this.Model}";
        }

        public virtual decimal KiraBedeliHesapla(int gunSayisi)
        {
            return this.GunlukUcret * gunSayisi;
        }
    }
}
