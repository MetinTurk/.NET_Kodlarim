using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Tekrari.NesnelerinInterneti
{
    internal abstract class AkilliCihaz : ICihaz
    {
        public bool AcikMi { get; set; }
        public Guid SeriNo { get; set; }

        protected AkilliCihaz()
        {
            this.SeriNo = Guid.NewGuid();
        }

        public override string ToString()
        {
            return $"{this.SeriNo} - Durum: {this.AcikMi}";
        }
    }
}
