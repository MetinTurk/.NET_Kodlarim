using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Tekrari.BilgisayarToplamaSihirbazi
{
    internal class Ram
    {
        public RamTipi ramTipi { get; set; }
        public Ram(RamTipi ramTipi, int kapasite)
        {
            this.ramTipi = ramTipi;
            if(kapasite<4 || kapasite > 128)
            {
                throw new Hatali("ram kapasitesi uyumsuzluğu");
            }
        }
    }
}
