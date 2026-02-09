using System;
using System.Collections.Generic;
using System.Text;

namespace AracKiralamaSistemi.Models
{
    internal class Tir : Tasit
    {
        public Tir(string Marka, string Model, double TasimaKapasitesi) : base(Marka, Model, 2000)
        {
            this.TasimaKapasitesi = TasimaKapasitesi;
        }

        public double TasimaKapasitesi { get; set; }

        public new string BilgiYazdir()
        {
            return $"Bu bir Tır'dır. Marka: {this.Marka}, Model: {this.Model}";
        }

    }
}
