namespace Hafta10Pazartesi.Ortak
{
    internal class Model
    {
        public string Ad { get; set; }

        public Model(string ad)
        {
            Ad = ad;

            Marka marka = new Marka(ad);
            marka.MarkayiTanit();
        }

    }
}
