using BaglamaSorusu.BaglamaParcalari;
using BaglamaSorusu.baglamaTurleri;

namespace BaglamaSorusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Tekne kisaTekne = new Tekne(AgacTuruTekne.Ardic, 24.0F);
            Kapak kisaKapak= new Kapak(AgacTuruKapak.Ladin, 24.0F);
            Govde govde = new Govde(kisaTekne, kisaKapak);
            Sap sap = new Sap(AgacTuruSap.Gurgen, 46.0F);
            Burgu burgu = new Burgu(AgacTuruBurgu.Pelesenk);
            KisaSapBaglama kisaSapBaglama = new KisaSapBaglama(govde, sap, burgu);
            kisaSapBaglama.AkortEt();
            kisaSapBaglama.Cal();
        }
    }
}
