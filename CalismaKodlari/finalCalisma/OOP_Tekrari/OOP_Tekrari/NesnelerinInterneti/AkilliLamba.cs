using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Tekrari.NesnelerinInterneti
{
    internal class AkilliLamba : AkilliCihaz
    {
        private int _parlaklik;
        public int Parlaklik 
        {
            get
            {
                return _parlaklik;
            }
            set 
            { 
                if (value < 0) 
                {
                    _parlaklik = 0;
                }
                else if(value >= 100)
                {
                    _parlaklik = 100;
                }
                else
                {
                    _parlaklik = value;
                }
            } 
        }
    }
}
