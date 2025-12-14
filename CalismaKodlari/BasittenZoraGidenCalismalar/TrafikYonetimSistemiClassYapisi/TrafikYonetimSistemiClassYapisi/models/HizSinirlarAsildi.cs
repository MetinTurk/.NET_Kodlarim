using System;
using System.Collections.Generic;
using System.Text;

namespace TrafikYonetimSistemiClassYapisi.models
{
    internal class HizSinirlarAsildi : Exception
    {
        public HizSinirlarAsildi(string mesaj) : base(mesaj)
        {

        }
    }
}
