using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Tekrari
{
    internal abstract class TemelNesne<TId> : IKayitNesnesi<TId>
    {
        public virtual TId Id { get; set; }
        public virtual DateTime KayitTarihi { get; set; }
        public virtual bool AktifMi { get; set; }

    }
}
