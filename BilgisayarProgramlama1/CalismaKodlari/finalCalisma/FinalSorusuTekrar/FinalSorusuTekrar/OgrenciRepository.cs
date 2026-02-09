using System;
using System.Collections.Generic;
using System.Text;

namespace FinalSorusuTekrar
{
    internal class OgrenciRepository<Ogrenci,int> : BaseRepository<Ogrenci, int>, IOgrenciRepository<Ogrenci, int>
    {
        public List<Ogrenci> GetAll()
        {
            throw new NotImplementedException();
        }

        public Ogrenci GetById(int key)
        {
            throw new NotImplementedException();
        }

        public string GetOgrenciAdSoyadbyOgrenciNo(string ogrenciNo)
        {
            throw new NotImplementedException();
        }
    }
}
