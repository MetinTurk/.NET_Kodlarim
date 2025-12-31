using System;
using System.Collections.Generic;
using System.Text;

namespace FinalSorusuTekrar
{
    internal abstract class BaseEntity<TKey> : IEntity<TKey>
    {
        public virtual DateTime OlusturulmaTarihi {  get; set; }
        public virtual bool  SilindiMi { get; set; }

        public virtual TKey Id { get; set; }

    }
}
