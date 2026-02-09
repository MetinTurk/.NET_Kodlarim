using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Tekrari
{
    internal class OyunKarti : IKart
    {
        public string Sembol { get; set; }
        public int Deger { get; set; }

        public override string ToString()
        {
            return $"{this.Sembol} - {this.Deger}";
        }
    }
}
