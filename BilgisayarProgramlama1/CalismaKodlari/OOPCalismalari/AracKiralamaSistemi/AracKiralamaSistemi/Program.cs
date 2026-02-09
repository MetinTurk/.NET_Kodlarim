using AracKiralamaSistemi.Models;

namespace AracKiralamaSistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Otomobil otomobil = new Otomobil("BMW" , "E60" , 500, 2);
            Console.WriteLine($"Kira bedeli: {otomobil.KiraBedeliHesapla(40)}");
            Tir tir = new Tir("MAN" , "DC560" , 25);
            Tasit referans = tir;
            Console.WriteLine(otomobil.BilgiYazdir());
            Console.WriteLine(referans.BilgiYazdir());
            Console.WriteLine($"Kira Bedeli: {referans.KiraBedeliHesapla(5)}");
        }
    }
}
