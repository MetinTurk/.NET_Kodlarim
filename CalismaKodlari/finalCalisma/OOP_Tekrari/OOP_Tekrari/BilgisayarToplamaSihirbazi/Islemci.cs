using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Tekrari.BilgisayarToplamaSihirbazi
{
    internal class Islemci
    {
        public IslemciMarkalari islemciMarkasi { get; set; }
        public Islemci(IslemciMarkalari islemciMarkasi)
        {
            this.islemciMarkasi = islemciMarkasi;
        }
    }

    
}
