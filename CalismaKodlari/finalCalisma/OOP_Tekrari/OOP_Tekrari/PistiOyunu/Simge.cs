using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Tekrari.PistiOyunu
{
    public enum Simge
    {
        Maca,
        Kupa,
        Karo,
        Sinek
    }
    public enum KartTur
    {
        As,
        Vale,
        Kız,
        Papaz,
        Bir,
        Iki,
        Uc,
        Dort,
        Bes,
        Alti,
        Yedi,
        Sekiz,
        Dokuz,
        On
    }

    public class HataliKart : Exception
    {
        public HataliKart(string message) : base(message)
        {
            
        }
    }
}
