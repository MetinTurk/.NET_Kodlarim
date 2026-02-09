using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceveErisimBelirleyiciler
{
    internal interface ITelefonDeposu : IDepo<Telefon>
    {
        Telefon GetirByImei(string imeiNo);

    }
}
