namespace eTicaretOtomasyonu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun("Malzeme" , 1000);
            Urun elektronikUrun = new ElektronikUrun("priz" , 300 , 30);
            Urun kazak = new GiyimUrunu("kazak" , 1200 , 20);
            Urun telefon = new DijitalUrun("telefon", 10000);
            Sepet sepet = new Sepet();

            sepet.UrunEkle(urun1);
            sepet.UrunEkle(elektronikUrun);
            sepet.UrunEkle(kazak);
            sepet.UrunEkle(telefon);
            sepet.UrunlerGoster();
            Console.WriteLine($"Toplam fatura tutarı: {sepet.ToplamTutarHesapla()}");
                
        }
    }
}
