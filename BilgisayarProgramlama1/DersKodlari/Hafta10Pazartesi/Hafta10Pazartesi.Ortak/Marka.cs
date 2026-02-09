using Hafta10Pazartesi.models;

namespace Hafta10Pazartesi.Ortak
{
    public class Marka
    {
        public string Ad { get; set; }

        public Marka(string ad)
        {
            Ad = ad;
        }

        internal void MarkayiTanit()
        {
            Console.WriteLine($"Benim markam ..... {Ad}");
            MailHelper m = new MailHelper();
            m.
        }
    }
}
