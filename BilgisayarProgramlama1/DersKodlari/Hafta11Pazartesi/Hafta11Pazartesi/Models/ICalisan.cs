using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Hafta11Pazartesi.Models
{
    public interface ICalisan
    {

        void Calis();
    }

    public interface IKisi
    {
        string Ad { get; set; }
        public string Soyad { get; set; }
    }

    
}
