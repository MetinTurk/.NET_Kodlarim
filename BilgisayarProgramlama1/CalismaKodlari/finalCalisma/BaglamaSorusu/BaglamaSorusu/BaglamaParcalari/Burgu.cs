using System;
using System.Collections.Generic;
using System.Text;

namespace BaglamaSorusu.BaglamaParcalari
{
    internal class Burgu
    {
        public Burgu(AgacTuruBurgu agacTuru)
        {
            this.AgacTuru = agacTuru;
        }

        public AgacTuruBurgu AgacTuru { get; set; }
    }
}
