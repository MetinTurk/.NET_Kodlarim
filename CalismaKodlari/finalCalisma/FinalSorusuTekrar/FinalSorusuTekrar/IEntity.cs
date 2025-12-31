using System;
using System.Collections.Generic;
using System.Text;

namespace FinalSorusuTekrar
{
    internal interface IEntity<TKey>
    {
        public DateTime OlusturulmaTarihi { get; set; }
        public bool SilindiMi { get; set; }
        public TKey Id { get; set; }
    }
}
