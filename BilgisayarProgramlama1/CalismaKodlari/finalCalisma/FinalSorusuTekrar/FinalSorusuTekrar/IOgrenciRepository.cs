using System;
using System.Collections.Generic;
using System.Text;

namespace FinalSorusuTekrar
{
    internal interface IOgrenciRepository<TEntitiy,TKey>:IRepository<Ogrenci , int> 
    {
        string GetOgrenciAdSoyadbyOgrenciNo(string ogrenciNo);



    }
}
