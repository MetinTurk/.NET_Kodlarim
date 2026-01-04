using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Tekrari.AkilliKonteyner
{
    internal class Koli: IYuk
    {
        public int Agirlik { get; }
        public Koli(int agirlik)
        {
            this.Agirlik = agirlik;
        }
    }
}
