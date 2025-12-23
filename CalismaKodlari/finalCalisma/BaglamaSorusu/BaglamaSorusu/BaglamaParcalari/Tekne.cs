using System;
using System.Collections.Generic;
using System.Text;

namespace BaglamaSorusu.BaglamaParcalari
{
    internal class Tekne
    {
        public Tekne(AgacTuruTekne agacTuru , float boy)
        {
            this.AgacTuru = agacTuru;
            this.Boy = boy;
        }

        public AgacTuruTekne AgacTuru { get; set; }
        public float Boy { get; set; }


    }
}

