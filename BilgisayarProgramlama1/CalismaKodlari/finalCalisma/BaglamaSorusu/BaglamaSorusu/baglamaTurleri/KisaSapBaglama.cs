using BaglamaSorusu.BaglamaParcalari;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaglamaSorusu.baglamaTurleri
{
    internal class KisaSapBaglama : Baglama
    {
        public KisaSapBaglama(Govde govde, Sap sap, Burgu burgu) : base(govde, sap, burgu)
        {
            if (!(govde._tekne.Boy > 23 && sap.Boy > 45))
            {
                throw new BoyUyumsuzlugu("Kisa Sap Baglama için govde boyu veya sap boyu uyumsuzluğu");
            }
        }

        public override void AkortEt()
        {
            Console.WriteLine("Kisa sap bağlama akort edildi");
        }

        public override void Cal()
        {
            Console.WriteLine("Kısa sap bağlama calındı");
        }
    }
}
