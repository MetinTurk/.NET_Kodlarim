using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceveErisimBelirleyiciler.uniKutuphaneSistemi
{
    internal class Kitap
    {
        public string Ad { get; set; }
        public string Yazar { get; set; }
        public string ISBN { get; set; }
        
        public Kitap(string ad, string yazar, string iSBN)
        {
            Ad = ad;
            Yazar = yazar;
            ISBN = iSBN;
        }

        



    }
}
