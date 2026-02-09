using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Tekrari.BilgisayarToplamaSihirbazi
{
    public enum IslemciMarkalari
    {
        Intel,
        AMD
    }

    public enum RamTipi
    {
        DDR4,
        DDR5
    }

    public class Hatali: Exception
    {
        public Hatali(string message): base(message)
        {
            
        }
    }
}
