using OOP_Tekrari.BilgisayarToplamaSihirbazi;

namespace OOP_Tekrari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Islemci islemci = new Islemci(IslemciMarkalari.AMD);
            Ram ram = new Ram(RamTipi.DDR4,256);
            Bilgisayar bilgisayar = new Bilgisayar(islemci,ram);
            Console.WriteLine(bilgisayar.ram.ramTipi);

        }
    }
}
