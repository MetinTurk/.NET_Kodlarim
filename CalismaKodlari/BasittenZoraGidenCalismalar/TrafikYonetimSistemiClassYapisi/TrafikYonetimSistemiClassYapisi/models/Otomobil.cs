using System;
using System.Collections.Generic;
using System.Text;

namespace TrafikYonetimSistemiClassYapisi.models
{
    internal sealed class Otomobil : Arac
    {
        public Otomobil(string plaka) : base(plaka)
        {
        }

        public override void MotoruCalistir()
        {
            Console.WriteLine("Sessiz motor çalıştı");
        }
    }
}
