using BaglamaSorusu.BaglamaParcalari;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaglamaSorusu.baglamaTurleri
{
    internal class Cura : Baglama
    {
        public Cura(Govde govde, Sap sap, Burgu burgu) : base(govde, sap, burgu)
        {
            if(!(govde._tekne.Boy > 30 && sap.Boy > 70))
            {
                throw new BoyUyumsuzlugu("Cura için govde boyu veya sap boyu uyumsuzluğu");
            }
        }

        public override void AkortEt()
        {
            throw new NotImplementedException();
        }

        public override void Cal()
        {
            throw new NotImplementedException();
        }
    }
}
