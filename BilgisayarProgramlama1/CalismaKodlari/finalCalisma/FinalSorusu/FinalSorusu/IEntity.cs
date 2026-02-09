using System;
using System.Collections.Generic;
using System.Text;

namespace FinalSorusu
{
    public interface IEntity<TKey>
    {
        DateTime OlusturmaTarihi { get; set; }
        bool SilindiMi { get; set; }
        TKey Id { get; set; }

    }
}
