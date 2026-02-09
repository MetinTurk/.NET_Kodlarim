using System;
using System.Collections.Generic;
using System.Runtime;
using System.Text;

namespace OOP_Tekrari.MuzikPlatformu
{
    internal abstract class MedyaOgesi<T> : IMedya<T>
    {
        public string Baslik { get; set; }
        public T Id { get; set;  }
        public double Sure { get; set; }

        public virtual string BilgiVer()
        {
            return $"{this.Baslik} - {this.Sure}";
        }

    }
}
