using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Tekrari.MuzikPlatformu
{
    internal interface IMedya<T>
    {
        public string Baslik { get; set; }
        public T Id { get; set; }
    }
}


