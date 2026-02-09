using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Tekrari.BilgisayarToplamaSihirbazi
{
    internal class Bilgisayar
    {
        public Islemci islemci { get; set; }
        public Ram ram { get; set; }
        public EkranKarti ekranKarti { get; set; }
        public Kasa kasa { get; set; }

        public Bilgisayar(Islemci islemci, Ram ram)
        {
            this.islemci = islemci;
            this.ram = ram;
            if (islemci.islemciMarkasi == IslemciMarkalari.Intel && ram.ramTipi != RamTipi.DDR5)
            {
                throw new Hatali("Intel işlemciler sadece DDR5 ile çalışır");
            }
        }

        void MontajYap()
        {

        }

        void Calistir()
        {
            if (ekranKarti == null)
            {
                Hatali hata = new Hatali("Goruntu yok");
            }
        }
    }
}
