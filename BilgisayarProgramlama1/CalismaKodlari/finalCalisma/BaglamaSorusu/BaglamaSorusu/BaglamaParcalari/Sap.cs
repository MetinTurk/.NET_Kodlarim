using System;
using System.Collections.Generic;
using System.Text;

namespace BaglamaSorusu.BaglamaParcalari
{
    internal class Sap
    {
        public Sap(AgacTuruSap agacTuru, float boy)
        {
            this.AgacTuru = agacTuru;
            this.Boy = boy;
        }

        public AgacTuruSap AgacTuru { get; set; }
        public float Boy { get; set; }
    }
}
