using System;
using System.Collections.Generic;
using System.Text;

namespace TrafikYonetimSistemiClassYapisi.models
{
    internal interface IKaraKutu
    {
        public string KaraKutu { get; set; }

        public void VeriyiKaydet();
    }
}
