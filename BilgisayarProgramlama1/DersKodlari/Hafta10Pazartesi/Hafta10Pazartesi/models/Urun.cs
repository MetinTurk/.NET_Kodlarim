namespace Hafta10Pazartesi.models
{
    internal class Urun
    {
        

		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}
        public string Ad { get; set; }  //derlendiğinde arka planda bir field oluşturuyor (biz onları görmüyoruz.)

        //public Urun()
        //{
        //    _id = 1;
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine("Ürün oluşturuldu.");
        //    }

        //}

        public Urun(int id)
        {
            this.id = id;

            //Atama işlemleri yapılıyor.
        }

        public Urun(int id, string ad) 
            : this(id)   //yukarıdaki constractor'ı çağırıp içerisinde yapılan işlemler yapılır sonrasında diğer constractor çalışır.
        {
            //this.id = id;

            Ad = ad;
            var fiyat = FiyatHesapla();
        }


        //public Urun(string ad)
        //{
        //    Ad = ad;
        //}

        private decimal FiyatHesapla()  //private sadece sınıf içerisinden erişilebilir.    //public her yerden erişilebilir olsun.
        {
            return id + 900;
        }


    }
}
