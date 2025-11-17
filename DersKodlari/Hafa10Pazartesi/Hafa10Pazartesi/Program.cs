namespace Hafa10Pazartesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //var guncelBakiye = BakiyeYukle(940, 50.0M);

            //var sonuc = FaktoriyekHesapla(5);

            int sayi = 1;

            HesapMakinesi hesapMakinesi = new HesapMakinesi();  //örneğini alma (instance)
            hesapMakinesi.sayi1 = 50;
            hesapMakinesi.sayi2 = 40;
            var toplamaSonucu = hesapMakinesi.Topla();

            var hesapmakinesi2 = new HesapMakinesi();

            Monitor monitor1 = new Monitor();
            //monitor1._boy = 120;
            //monitor1._en = 50;
            //monitor1.cozunurluk = "1280X1024";
            //monitor1.Start();
            //monitor1.Kapat();

            monitor1.En = 50;
            Console.WriteLine(monitor1.En);
            monitor1.Marka = "ASUS";
            monitor1.Model = "PW789";

            var markasi = monitor1.Marka;
            //monitor1.Fiyat = 15654;       //set etme şansın yok sadece read-only
            Console.WriteLine(monitor1.Fiyat);

            monitor1.SeriNumarasi = "TR156564654516465";
            //Console.WriteLine(monitor1.SeriNumarasi); //get etme okuma şansın yok write-only


            Ogrenci sila = new Ogrenci();
            sila.Ad = "Sila";
            sila.Soyad = "Türk".ToUpper();
            sila.DogumTarihi = new DateTime(2000, 03, 15);
            sila.OgrenciNumarasi = "1565461161320";

            var tamAd = $"{sila.Ad} {sila.Soyad}";
            Console.WriteLine($"{sila.Ad} {sila.Soyad}");
            Console.WriteLine(tamAd);
            //hesaplanmış prop
            Console.WriteLine(sila.TamAd);
            sila.YemekYe();
            sila.Calis();
            sila.Gez();
            //sila.TcKimlikNo = "1515456123"; //init olduğu için atama yapılmaz

            var ogrenci2 = new Ogrenci()
            {
                Ad = "Metin",
                Soyad = "Türk",
                DogumTarihi = new DateTime(1998, 07, 4),
                OgrenciNumarasi = "13568453651684",
                TcKimlikNo = "15464561215"  //init olduğu için sadece burada atama yapılır
            };

            Console.WriteLine(ogrenci2.TamAd);

            Urun urun = new Urun();
            Console.WriteLine(urun.Marka);

            Urun urun2 = new Urun("ASUS");  
            Console.WriteLine(urun2.Marka);

            Urun urun3 = new Urun("ASUS","Z899");
            Console.WriteLine(urun3.Marka);

            GarbageCollectorTest();
            GC.Collect();

        }
        #region Methodlar
        //static decimal BakiyeYukle(int hesapKodu, decimal bakiye) //imzası farklı olması lazım (farlı paremetre alan , geri dönüş değeri farkı olan ve aldığı paremetre sıralamaları farklı olan)
        //{
        //    return 90;
        //}

        //static decimal BakiyeYukle(decimal bakiye, int hesapKodu) 
        //{
        //    return 90;
        //}

        //static decimal BakiyeYukle(int mevcutHesapKodu, decimal bakiye, string krediKartiNo)        //overloading yaparken opsiyon olarak paremetre eklemeyin.
        //{
        //    return 123;
        //}

        //static int FaktoriyekHesapla(int sayi)
        //{
        //    if(sayi <= 0)
        //    {
        //        return 1;
        //    }
        //    return sayi * FaktoriyekHesapla(sayi - 1);
        //} 
        #endregion

        static void GarbageCollectorTest()
        {
            Urun urun = new Urun("asdasdasdasd");
        }

    }

    public class HesapMakinesi
    {
        public int sayi1;       //Bu şekilde field'ları sınıf dışarısından erişime açmayacağız
        public int sayi2;

        public int Topla()
        {
            return sayi1+sayi2;
        }
        public int Cikart()
        {
            return sayi1 - sayi2;
        }

        


    }

    public class Monitor
    {
        int _en;
        int _boy;
        string _cozunurluk = "800x600";

        //public void SetEn(int en)     //bunlara .NET taafında gerek yok
        //{
        //    _en = en;
        //}
        //public int GetEn()
        //{
        //    return _en;
        //}

        public int En
        {
            get
            {
                return _en;
            }
            set
            {
                _en = value;
            }
        }

        public int Boy
        {
            get
            {
                return _boy;
            }
            set
            {
                if (value < 0)
                    _boy = 0;
                else
                _boy = value;
            }
        }

        private string _marka;

        public string Marka
        {
            get { return _marka; }
            set { _marka = value; }
        }

        //propfull snippet

        //arka planda kendisi field oluşturup kullanmamızı sağlıyor
        public string Model { get; set; }

        //prop snippet

        private decimal _fiyat;

        public decimal Fiyat
        {
            get { return _fiyat; }
        }
        //sadece get yapacaksak kullanılır
        public decimal Fiyat1 => _fiyat;

        private string _seriNumarasi;

        public string SeriNumarasi
        {
            set { _seriNumarasi = value; }
        }

        //sadece reak-only yapılabilir sadece okunur.
        public bool CalisiyorMu { get; }
        //sadece write-only yapılamaz
        //public bool CalisiyorMu2 { set; }




        public void Start()
        {
            Console.WriteLine("Monitor çalıştırıldı");
        }

        public void Kapat()
        {
            Console.WriteLine("Monitör kapatıldı");
        }


    }

    public class Ogrenci
    {
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public DateTime DogumTarihi;

        private string _ogrenciNumarasi;
            
        public string OgrenciNumarasi
        {
            get { return _ogrenciNumarasi; }
            set {
                if (value.Length != 10)
                    _ogrenciNumarasi = "12316546513";
                else
                    _ogrenciNumarasi = value;
            }
        }

        //hesaplanmış property
        public string TamAd => $"{Ad} {Soyad}";

        //init = 
        public string TcKimlikNo { get; init; }

        public void YemekYe()
        {
            Console.WriteLine("Yemek yendi");
        }

        public void Calis()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ders çalışıldı");
            }
        }

        public void Gez()
        {
            Console.WriteLine("Gezdi");
        }
    }

    public class Urun
    {
        private string _marka;

        public string Marka
        {
            get { return _marka; }
            set { _marka = value; }
        }

        //sınıfın ismi ne ise constructor ismi de aynısı olmalı (Urun => Urun)
        public Urun()
        {
            _marka = "HP";
        }


        public Urun(string marka)
        {
            _marka = marka;
        }

        public Urun(string marka, string model)
        {
            _marka = marka;
            Model = model;
        }

        //nesnelerin örneklenip stack üzerinden silinirse ve nesne örneğinin değerlerinin heap de kalması sonucunda GarbageCollector çalışır çalıştığında da bu kısım çalış nesennin son istekleri yerine getirlir.
        ~Urun()
        {
            Console.WriteLine("Artık bizimle değilsin");
            Console.WriteLine($"{this.Marka}");
        }


        public string Model { get; set; }
    }
}
