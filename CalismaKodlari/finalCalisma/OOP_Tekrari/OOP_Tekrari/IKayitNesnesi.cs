using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Tekrari
{
    internal interface IKayitNesnesi<TId>
    {
        public TId Id { get; set; }
        public DateTime KayitTarihi { get; set; }
        public bool AktifMi { get; set; }
    }
}
