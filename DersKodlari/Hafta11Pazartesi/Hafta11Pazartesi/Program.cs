using Hafta11Pazartesi.Models;

namespace Hafta11Pazartesi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region İLK DERS
            //IslemYap("Erkrk");

            //IslemYap(Cinsiyet.Erkek);

            //var metin = new Calisan();
            //metin.Calis();

            //Yonetici sila = new Yonetici();
            //sila.BirimiYonet();

            ////Calisan referansı üzerinden yonetici nesnesinin örneğini aldık
            //Calisan ata = new Yonetici();


            //Calisan[] calisanlar = new Calisan[10];
            //calisanlar[0] = metin;
            //calisanlar[1] = sila;
            //calisanlar[2] = ata;



            //Patron patron = new Patron();
            //calisanlar[3] = ata;
            //patron.TunPersoneliCalistir(calisanlar);


            //ICalisan[] calisanlar2 = new ICalisan[10];
            //calisanlar2[0] = metin;
            //calisanlar2[1] = sila;
            //calisanlar2[2] = ata;
            //calisanlar2[3] = ata;
            //calisanlar2[4] = new Robot();

            //object ulku = new Yonetici();
            //object selin = new Patron();
            //object selin2 = 11;

            //IKisi[] calisanlar3 = new IKisi[10];
            //calisanlar3[0] = metin;
            //calisanlar3[1] = sila;
            //calisanlar3[2] = ata;
            //calisanlar3[3] = ata; 

            //ICalisan calisan = new Calisan();
            //ICalisan calisan2 = new Yonetici();
            //ICalisan calisan3 = new Patron();
            //ICalisan calisan4 = new Robot();
            ////yapamayız interface örneği alınamaz.
            ////ICalisan calisan5 = new ICalisan();

            
            #endregion

            Marka marka = new Marka();

            Model model = new Model();

            //abstract sınıf olduğu için örneği alınamaz.
            //BaseTur baseTur = new BaseTur();
            //baseTur.Ad = "asdasd";
            //baseTur.Id = 1;

            BaseTur asus = new Marka();
            BaseTur asusProjeksiyon = new Model();
            //nesne örneği alınamaz (sadece kalıtım amaclı kullanılır.)
            //BaseTur hp = new BaseTur();

            


            Console.WriteLine("Hello, World!");
        }

        static void IslemYap(string cinsiyet)
        {
            if(cinsiyet.ToLower() == "erkek")
            {

            }
            else if(cinsiyet.ToLower() == "kadın")
            {

            }
            else
            {
                Console.WriteLine("Böyle bir cinsiyet tanımlı değildir");
            }
                Console.WriteLine(cinsiyet);
        }

        static void IslemYap(Cinsiyet cinsiyet)
        {
            switch (cinsiyet)
            {
                case Cinsiyet.Erkek:
                    {

                        break;
                    }
                case Cinsiyet.Kadın:
                    {

                        break;
                    }
                default:
                    {

                        break;
                    }
            }
            Console.WriteLine(cinsiyet);
        }

        //sınıf içerisinde private class tanımlayabiliriz
        //private class Urun
        //{

        //}
    }

    //Dev. kullanırken yazım hatası yapmasın diye
    public enum Cinsiyet
    {
        Erkek = 0,
        Kadın = 1
    }



}
