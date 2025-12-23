using System;
using System.Collections.Generic;
using System.Text;

namespace BaglamaSorusu.BaglamaParcalari
{
    internal class Kapak
    {
        public Kapak(AgacTuruKapak agacTuru, float boy)
        {
            this.AgacTuru = agacTuru;
            this.Boy = boy;
        }

        public AgacTuruKapak AgacTuru { get; set; }
        public float Boy { get; set; }
    }
}
