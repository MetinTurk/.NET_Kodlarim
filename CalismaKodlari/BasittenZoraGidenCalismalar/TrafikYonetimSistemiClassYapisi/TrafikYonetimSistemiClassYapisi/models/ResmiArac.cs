using System;
using System.Collections.Generic;
using System.Text;

namespace TrafikYonetimSistemiClassYapisi.models
{
    internal class ResmiArac : Arac
    {
        public string KurumAdi { get; set; }
        public ResmiArac(string plaka , string kurumAdi) : base(plaka)
        {
            this.KurumAdi = kurumAdi;
        }

        public override void MotoruCalistir()
        {
            Console.WriteLine("Standart resmi motor çalıştı");   
        }
    }
}
