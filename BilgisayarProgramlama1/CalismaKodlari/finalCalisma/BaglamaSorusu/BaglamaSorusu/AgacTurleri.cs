using System;
using System.Collections.Generic;
using System.Text;

namespace BaglamaSorusu
{
    internal class AgacTurleri
    {
        

    }

    public enum AgacTuruTekne
    {
        Dut,
        Maun,
        Ardic,
        Vengi,
        Paduk
    }

    public enum AgacTuruKapak
    {
        Ladin,
        KanadaCami
    }

    public enum AgacTuruSap
    {
        Gurgen,
        Maun
    }

    public enum AgacTuruBurgu
    {
        Pelesenk,
        Gurgen
    }
    public class BoyUyumsuzlugu : Exception
    {
        public BoyUyumsuzlugu(string message) : base(message)
        {

        }
    }
}
