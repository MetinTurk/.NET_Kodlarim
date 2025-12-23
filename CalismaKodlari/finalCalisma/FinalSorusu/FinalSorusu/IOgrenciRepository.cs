using System;
using System.Collections.Generic;
using System.Text;

namespace FinalSorusu
{
    public interface IOgrenciRepository : IRepository<Ogrenci, int>
    {
        public string GetOgrenciAdSoyadbyOgrenciNo(string ogrenciNo);
    }
}
