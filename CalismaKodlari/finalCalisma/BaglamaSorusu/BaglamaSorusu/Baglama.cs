using BaglamaSorusu.BaglamaParcalari;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaglamaSorusu
{
    internal abstract class Baglama
    {
        public Baglama(Govde govde, Sap sap, Burgu burgu)
        {
            _govde = govde;
            _sap = sap;
            _burgu = burgu;
        }

        public Govde _govde{ get; set; }
        public Sap _sap{ get; set; }
        public Burgu _burgu{ get; set; }

        public abstract void AkortEt();
        public abstract void Cal();
        


    }
}
