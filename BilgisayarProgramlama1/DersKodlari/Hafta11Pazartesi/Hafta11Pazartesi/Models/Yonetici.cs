namespace Hafta11Pazartesi.Models
{
    public class Yonetici : Calisan
    {
        public string YonetilenBirim { get; set; }

        public void BirimiYonet()
        {

        }

        public override void Calis()
        {
            base.Calis();
            Console.WriteLine("Yönetici Çalışıyor");
        }

        public void IzinIste(Calisan calisan)
        {
            Console.WriteLine("İzin verildi");
        }
    }
}
