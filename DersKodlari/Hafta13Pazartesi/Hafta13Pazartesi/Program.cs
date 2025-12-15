using System.Collections;

namespace Hafta13Pazartesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Generic
            //var esitMi = EsitMi(2, 2);
            //esitMi = EsitMi(2, 5);
            //esitMi = EsitMi(2.2, 5.6);

            //esitMi = EsitMi<bool>(true,false);
            //esitMi = EsitMi<bool>(true,true);

            //esitMi = EsitMi<decimal>(12.5M,15.9M);

            //Console.WriteLine("Hello, World!");

            //var uniqIdentifier = Guid.NewGuid();

            //Console.WriteLine(uniqIdentifier);



            //var test = new Entity<int>();
            //test.Id = 12;
            //var sonuclar = test.GetAll();
            //test.GetById(12);


            //var test2 = new Entity<string>();
            //test2.Id = "123";
            //var sonuc2 = test2.GetAll();
            //test2.GetById("123");

            //var test3 = new Entity<Guid>();
            //test3.Id = Guid.NewGuid();
            //var sonuc3 = test3.GetAll();
            //test3.GetById();

            //IDepo<Marka, int> markaDeposu = new Depo<Marka, int>();
            //markaDeposu.Id = 23;
            //var tumMarkalar = markaDeposu.GetAll();


            //IDepo<Urun, Guid> urunDeposu = new Depo<Urun, Guid>();
            //urunDeposu.Id = Guid.NewGuid();
            //var tumUrunler = urunDeposu.GetAll();

            ////IDepo<int, Guid> testDeposu = new Depo<int, Guid>();    //T : class olması gerekiyor int ile çalışamayız 
            #endregion

            var emptyGuid = Guid.Empty;     //veri tamamen 0 olur 



            ArrayList yaslar2 = new ArrayList();
            yaslar2.Add(12);
            yaslar2.Add("Metin");
            List<int> yaslar = new List<int>();
            yaslar.Add(12);
            //yaslar.Add("Metin");    //sadece int değerler alır T : int
            yaslar.Add(23);
            yaslar.Add(99);

            for (int i = 0; i < 10; i++)
            {
                yaslar.Add(i);
            }

            yaslar.Insert(0, 100);

            var aSubesininYaslari = new int[] { 19, 18, 19, 20, 21, 18, 18 };
            yaslar.AddRange(aSubesininYaslari);

            yaslar.InsertRange(2, aSubesininYaslari);

            yaslar.Remove(100);
            yaslar.RemoveAt(5);
            yaslar.Clear();

            var elemanSayisi = yaslar.Count;
            var kapasite = yaslar.Capacity;



            List<string> ogrenciler = new List<string>();
            ogrenciler.Add("Metin");
            ogrenciler.Add("Sila");
            ogrenciler.Add("Ata");
            ogrenciler.Add("Ülkü");


            List<double> havaDurumlari = new List<double>();

            List<Marka> Markalar = new List<Marka>(30); //30 tane marka ekleyebiliyoruz Capacity değeri verdik.

            Markalar.Add(new Marka("HP"));
            Markalar.Add(new Marka("Asus"));
            Markalar.Add(new Marka("Monster"));
            Markalar.Add(new Marka("Lenovo"));
            var kapasiteMarkalar = Markalar.Capacity;

            for (int i = 0; i < Markalar.Count; i++)
            {
                var seciliMarkaAdi = Markalar[i].Adi;
                Console.WriteLine(seciliMarkaAdi);
            }

            foreach (var marka in Markalar)
            {
                Console.WriteLine(marka.Adi);
            }


            Dictionary<int, string> gunler = new Dictionary<int, string>();
            gunler.Add(1, "Pazartesi");
            gunler.Add(2, "Sali");
            gunler.Add(3, "Çarşamba");
            gunler.Add(4, "Perşembe");
            gunler.Add(6, "Cumartesi");
            gunler.Add(5, "Cuma");
            gunler.Add(7, "Pazar");

            //gunler.Add(6, "Cumartesi");       //6 numaralı key dolu başka bir key kullan. (value'nun bir önemi yok)
            // 6 keyi daha önce eklendiği için tekrar eklenemez.

            var ilkGun = gunler[0];
            var eldeEdildiMi = gunler.TryGetValue(1, out ilkGun);
            if(eldeEdildiMi = gunler.TryGetValue(0, out ilkGun))
            {

            }

            var eklendiMi = gunler.TryAdd(8, "Benim Günüm");

            gunler.Remove(8);
            //gunler.Clear();


            foreach (var gun in gunler)
            {
                Console.WriteLine(gun.Key + " " + gun.Value);
            }


            Dictionary<string, Marka> markalar2 = new Dictionary<string, Marka>
            {
                {"Asus", new Marka("Asus") },
                {"Hp", new Marka("Hp") },
               
            };

            markalar2.Add("Dell", new Marka("Dell"));

            var dell = markalar2["Dell"];

            foreach (var marka in markalar2)
            {
                Console.WriteLine(marka.Key  + " " + marka.Value);
            }


            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(5);
            stack.Push(20);
            stack.Push(4);

            var alinanDeger = stack.Pop();
            alinanDeger = stack.Pop();

            while (stack.Count > 0)
            {
                alinanDeger = stack.Pop();
                Console.WriteLine(alinanDeger);
            }

            if(stack.TryPop(out int test))
            {

            }


            Stack<string> stack2 = new Stack<string>();
            stack2.Push("10");
            stack2.Push("50");
            stack2.Push("20");
            stack2.Push("40");

            Stack<Marka> stackMarka = new Stack<Marka>();
            stackMarka.Push(new Marka("HP"));


            Queue<int> kuyruk = new Queue<int>();
            kuyruk.Enqueue(1);
            kuyruk.Enqueue(5);
            kuyruk.Enqueue(20);
            kuyruk.Enqueue(4);


            var siradaki = kuyruk.Dequeue();

            var elemanVarMi = kuyruk.TryDequeue(out siradaki);


            while (kuyruk.Count > 0)
            {
                alinanDeger = kuyruk.Dequeue();
                Console.WriteLine(alinanDeger);
            }


            Queue<string> kuyruk2 = new Queue<string>();

            kuyruk2.Enqueue("Metin");
            kuyruk2.Enqueue("Sila");
            kuyruk2.Enqueue("Ata");
            kuyruk2.Enqueue("Ülkü");


            while (kuyruk.Count > 0)
            {
                var islemYapilacakKisi = kuyruk2.Dequeue();
                Console.WriteLine(islemYapilacakKisi);
            }
            



        }


        public static bool EsitMi<T>(T deger1 , T deger2)
        {
            return deger1.Equals(deger2);
        }
        //public static bool EsitMi(int deger1 , int deger2)
        //{
        //    return (deger1 == deger2);
        //}

        //public static bool EsitMi(double deger1, double deger2)
        //{
        //    return (deger1 == deger2);
        //}
    }

    //public interface IEntity
    //{
    //    Guid Id { get; set; }

    //    void Test();


    //}

    //public class Entity : IEntity
    //{
    //    public Guid Id { get; set; }

    //    public void Test()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}


    public interface IEntity<T>
    {
        T Id { get; set; }

        T[] GetAll();

        void GetById(T id);


    }

    public class Urun
    {

    }

    public class Entity<T> : IEntity<T>
    {
        public T Id { get; set; }

        public T[] GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetById(T id)
        {
            throw new NotImplementedException();
        }

        public Entity(T id)
        {
            this.Id = id;
        }

    }

    public class Marka
    {
        public string Adi { get; set; }
        public Marka(string adi)
        {
            this.Adi = adi;
        }
    }

    public interface IDepo<T,TKey> where T : class  //T tipini class vermek zorundasın
    {
        TKey Id { get; set; }
        T GetbyId(TKey id);
        T[] GetAll();
    }

    //Tip kısıtı koyulabilir 
    public class Depo<T, TKey> : IDepo<T,TKey> where T : class //where T :  IDeneme   //IDeneme interface'ini implemente eden bir sınıf kullanmak zorundason
    {
        public TKey Id { get; set; }

        public T[] GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetbyId(TKey id)
        {
            throw new NotImplementedException();
        }
    }

    public interface IDeneme
    {

    }
}
