using System;
using System.Collections.Generic;
using System.Text;

namespace Hafta01.Services
{
    internal interface IOgrenciService
    {
        List<Ogrenci> GetTumOgrenciler();
    }

    public class OgrenciService : IOgrenciService

    {
        public List<Ogrenci> GetTumOgrenciler()
        {
            return new List<Ogrenci> { new Ogrenci(1,"Sila","Test" , "2312721011",22,1),
                                        new Ogrenci(2,"Metin","Deneme" , "2312721051",18,0),
                                        new Ogrenci(3,"Ata","Türk" , "2312721088",5,0),
                                        new Ogrenci(4,"Betül","Test" , "2312721047",14,1),
                                        new Ogrenci(4,"Semih","Test" , "2312721048",18,0)
            };
        }
    }
}
