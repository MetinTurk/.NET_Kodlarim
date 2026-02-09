using System.Collections;

namespace DosyaYonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //StreamReader sr = File.OpenText("deneme.txt");
            //var s = "";
            //while ((s = sr.ReadLine()) != null)
            //{
            //    Console.WriteLine(s);
            //}

            //string sonuc = File.ReadAllText("deneme.txt");
            //Console.WriteLine(sonuc);

            //string[] sonuc = File.ReadAllLines("deneme.txt");
            //Console.WriteLine(sonuc[0]);
            //Console.WriteLine(sonuc[1]);

            //using (StreamWriter sw = File.CreateText("deneme.txt"))
            //{
            //    sw.WriteLine("merhaba");
            //    sw.WriteLine("BTK");
            //    sw.WriteLine("Akedemi");
            //    //sw.Close();
            //}


            //using (StreamWriter sw = File.AppendText("deneme.txt"))
            //{
            //    sw.WriteLine("merhaba");
            //    sw.WriteLine("BTK");
            //    sw.WriteLine("Akedemi");
            //}

            //StreamReader sr = File.OpenText("deneme.txt");
            //var s = "";
            //while ((s = sr.ReadLine()) != null)
            //{
            //    Console.WriteLine(s);
            //}

            //File.WriteAllText("deneme.txt", "merhaba");
            //File.AppendAllText("deneme.txt", "merhaba");


            //Directory.CreateDirectory("temp");
            //Directory.CreateDirectory("temp/deneme");
            //Directory.CreateDirectory("temp/deneme2");
            //Directory.Delete("temp/deneme2");

            //if (Directory.Exists("temp/deneme2"))
            //{
            //    Directory.Delete("temp/deneme2");
            //}
            //else
            //{
            //    Console.WriteLine("Silmek istediğiniz klasör yok");
            //}

            //Directory.Move("temp/deneme", "temp/deneme2");  //klasör taşımak
            //string path = @"C:\temp";
            //Directory.CreateDirectory(path);        //dosya yolu verip klasor oluşturma

            //path = Directory.GetCurrentDirectory(); //projenin bulunduğu konumu verir.
            //Console.WriteLine(path);
            //path += "/temp";
            //Directory.CreateDirectory(path);

            //string rootPath = Directory.GetCurrentDirectory();

            //string[] dirs  = Directory.GetDirectories(rootPath,"*" , SearchOption.TopDirectoryOnly);
            //foreach (var dir in dirs)
            //{
            //    Console.WriteLine(dir);
            //}

            //string[] files = Directory.GetFiles(rootPath, "*.txt" , SearchOption.AllDirectories);
            //foreach (string file in files)
            //{
            //    Console.WriteLine(file);
            //    Console.WriteLine(Path.GetExtension(file));
            //    Console.WriteLine(Path.GetFileNameWithoutExtension(file));
            //    Console.WriteLine(Path.GetFileName(file));

            //    var info = new FileInfo(file);
            //    Console.WriteLine($"{Path.GetFileName(file)} : {info.Length}");
            //}

            #region ArrayList
            //ArrayList liste = new ArrayList();
            //liste.Add(10);
            //liste.Add("10");
            //liste.Add("sila");
            //liste.Add(null);
            //liste.Add(true);

            //var liste2 = new ArrayList{
            //    5,
            //    "ahmet",
            //    false,
            //    4.5,
            //    null
            //};

            //int[] sayilar = { 10, 20, 30 };

            //liste.AddRange(sayilar);

            //var eleman = liste[0];  //object türünde verir
            //var isim = liste[2].ToString();
            //Console.WriteLine((int)eleman);


            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item);
            //}

            ////insert

            //liste.Insert(1, "Metin");
            //liste.InsertRange(2, liste2);


            ////remove

            //liste.Remove(null);
            //liste.RemoveAt(2);
            //liste.RemoveRange(2,3);

            ////contains, index of
            //Console.WriteLine(liste.Contains(100));     //True False döndürür içeriyor mu diye bakar.
            //Console.WriteLine(liste.IndexOf(10)); 
            #endregion


            #region Generic List
            //List<int> sayilar = new List<int>();

            //sayilar.Add(10);
            //sayilar.Add(20);

            //List<string> isimler = new List<string>() { "sila" , "metin" , "ata", null};


            //List<Product> urunler = new List<Product>();

            //urunler.Add(new Product() { Id = 1 , Title = "IPhone 14" , Price = 80000});
            //urunler.Add(new Product() { Id = 2 , Title = "IPhone 13" , Price = 50000});
            //urunler.Add(new Product() { Id = 3 , Title = "IPhone 12" , Price = 30000});

            //foreach (var urun in urunler)
            //{
            //    Console.WriteLine(urun.Title + " " +  urun.Price);
            //}

            //urunler.Insert(urunler.Count, new Product()
            //{
            //    Id = 4, Title = "IPhone 11", Price = 20000
            //});

            //foreach (var urun in urunler)
            //{
            //    Console.WriteLine(urun.Title + " " + urun.Price);
            //}

            //urunler.RemoveAt(2);
            //urunler.Remove(urunler[0]); 
            #endregion


            Dictionary<int, string> plakalar = new Dictionary<int, string>();

            plakalar.Add(41, "Kocaeli");
            plakalar.Add(34, "İstanbul");
            plakalar.Add(26, "Eskişehir");

            Dictionary<int , string> sayilar = new Dictionary<int , string>()
            {
                {1,"Bir" },
                {2,"İki" },
                {3,"Üç" },
            };

            Console.WriteLine(plakalar[41]);
            if (plakalar.ContainsKey(61))
            {
                Console.WriteLine(plakalar[61]);

            }

            foreach (var plaka in plakalar)
            {
                Console.WriteLine(plaka.Key + " " + plaka.Value);
            }

            //update

            sayilar[1] = "one"; //key indis , value değeri
            sayilar.Remove(1);
            Console.WriteLine(sayilar[1]);

            sayilar.Clear();

        }
    }

    class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
    }
}
