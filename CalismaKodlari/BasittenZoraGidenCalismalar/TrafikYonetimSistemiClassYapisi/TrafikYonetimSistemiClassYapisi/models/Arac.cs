using System;
using System.Collections.Generic;
using System.Text;

namespace TrafikYonetimSistemiClassYapisi.models
{
    internal abstract class Arac
    {
        public string Plaka { get; }
        public DateTime aracTarihi;
        private int _hiz;

        public int Hiz
        {
            get { return _hiz; }
            set
            {
                if( value < 0  )
                {
                    throw new HizSinirlarAsildi("Hız negatif olamaz");
                }
                else if( value > 300)
                {
                    throw new HizSinirlarAsildi("Hız limitleri ihlal edildi");
                }
                _hiz = value;
            }
        }


        public Arac(string plaka)
        {
            this.Plaka = plaka;
            this.aracTarihi = DateTime.Now;
            this._hiz = 0;
        }

        public abstract void MotoruCalistir();
    }
}
