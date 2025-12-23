using System;
using System.Collections.Generic;
using System.Text;

namespace FinalSorusu
{
    public class OgrenciRepository : BaseRepository<Ogrenci, int> , IOgrenciRepository 
    {
        
        public string GetOgrenciAdSoyadbyOgrenciNo(string ogrenciNo)
        {
            throw new NotImplementedException();
        }

        List<Ogrenci> IRepository<Ogrenci, int>.GetAll()
        {
            throw new NotImplementedException();
        }
        public Ogrenci GetById(int key)
        {
            throw new NotImplementedException();
        }
    }
}
