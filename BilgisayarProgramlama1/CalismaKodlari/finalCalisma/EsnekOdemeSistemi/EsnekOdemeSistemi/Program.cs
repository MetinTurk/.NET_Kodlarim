namespace EsnekOdemeSistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Urunler telefon = new Urunler("Telefon" , 5000);
            Urunler kulaklik = new Urunler("Kulaklik ", 1000);
            Sepet sepet = new Sepet();
            sepet.SepeteEkle(telefon);
            sepet.SepeteEkle(kulaklik);
            sepet.Ode(new KrediKartiOdeme());
            sepet.Ode(new HavaleOdeme());



        }
    }
}
