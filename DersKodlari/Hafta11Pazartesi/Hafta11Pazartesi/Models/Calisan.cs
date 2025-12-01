namespace Hafta11Pazartesi.Models
{
    public class Calisan : ICalisan , IKisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public virtual void Calis()
        {
            Console.WriteLine("Çalışıyorum");
        }
    }
}
