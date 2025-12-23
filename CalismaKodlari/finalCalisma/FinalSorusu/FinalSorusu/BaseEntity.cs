using System;
using System.Collections.Generic;
using System.Text;

namespace FinalSorusu
{
    public abstract class BaseEntity<TKey> : IEntity<TKey>
    {
        public virtual DateTime OlusturmaTarihi { get; set; }
        public virtual bool SilindiMi { get; set; }
        public virtual TKey Id { get; set; }
    }
}
