using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BaglamaSorusu.BaglamaParcalari
{
    internal class Govde
    {
        public Tekne _tekne { get; set; }
        public Kapak _kapak { get; set; }

        public Govde(Tekne tekne, Kapak kapak)
        {
            if(tekne.Boy == kapak.Boy)
            {
                this._tekne = tekne;
                this._kapak = kapak;
            }
            else
            {
                throw new BoyUyumsuzlugu("Tekne ve kapak boyları uymuyor lütfen tekrar deneyin");
            }

        }

    }
    
}
