using Hafta01.Services;
using System.Reflection.Metadata.Ecma335;

namespace Hafta01
{
    internal class Program
    {
        #region 1.Saat
        ////private readonly IOgrenciService ogrenciService = new OgrenciService();   //böylede kullanılabilir

        //private readonly IOgrenciService ogrenciService;        //kafasına göre instance değiştirilmesin diye readonly
        //public Program()
        //{
        //    ogrenciService = new OgrenciService();
        //}

        static void Main(string[] args)
        {
            //    //LINQ Language ntegrated Query
            //    // 1- Query Syntax
            //    // 2- Method Syntax

            //    Console.WriteLine("Hello, World!");

            //    int[] sayilar = new int[] { 25 , 68, 98, 45, 12 ,45 ,65 ,13};

            //    List<int> sonuc = new List<int>();
            //    for (int i = 0; i < sayilar.Length; i++)
            //    {
            //        var sayi = sayilar[i];
            //        if(sayi > 50)
            //        {
            //            sonuc.Add(i);
            //        }
            //    }

            //    foreach (var item in sonuc)
            //    {
            //        Console.WriteLine(sonuc);
            //    }


            //    //select *
            //    //from Test t
            //    //where t.Sayi > 50

            //    // 1- Query Syntax
            //    var sonuc2 = (from t in sayilar 
            //                 where t > 50
            //                 select t).ToList();

            //    //2 - Method Syntax
            //    var sonuc2M = sayilar
            //        .Where(x => x > 50)
            //        //.Select(x => x)   //istersen yazabilirsin fakat zaten sql'de yıldız (*) gelicek
            //        .ToList();

            //    Program p = new Program();
            //    var ogrenciler = p.ogrenciService.GetTumOgrenciler();

            //    //Anonim = sadece yazdığımız method'un içerisinde kullanıcaksak 
            //    //DTO = dışarıda kullanmamız gerekirse (method paremetresi olabilir , return dönmemiz gerekirse)

            //    // 1- Query Syntax
            //    var sonucOgrenciler = (from o in ogrenciler
            //                          where o.Yas < 20 
            //                          select o).ToList();//.ToArray();

            //    //2 - Method Syntax
            //    var sonucOgrencilerM = ogrenciler
            //                           .Where(x => x.Yas < 20)
            //                           .ToList();//.ToArray();

            //    // 1- Query Syntax
            //    var sonucOgrenciler2 = (from o in ogrenciler
            //                           where o.Yas < 20 && o.CinsiyetId == 0
            //                           select o).ToList();//.ToArray();
            //    //2 - Method Syntax
            //    var sonucOgrenciler2M = ogrenciler
            //                           .Where(o => o.Yas < 20 && o.CinsiyetId == 0)
            //                           .ToList();//.ToArray();
            //    // 1- Query Syntax
            //    var sonucOgrenciler3 = (from o in ogrenciler
            //                            where o.Yas < 20 && o.CinsiyetId == 0
            //                            select new          //Anonim is Type
            //                            {
            //                                o.Ad,
            //                                o.Soyad
            //                            }).ToList();
            //    //2 - Method Syntax
            //    var sonucOgrenciler3M = ogrenciler
            //                           .Where(o => o.Yas < 20 && o.CinsiyetId == 0)
            //                           .Select(x => new     //Anonim is Type
            //                           {
            //                               x.Ad,
            //                               x.Soyad
            //                           })
            //                           .ToList();//.ToArray();

            //    // 1- Query Syntax
            //    var sonucOgrenciler4 = (from o in ogrenciler
            //                            where o.Yas < 20 && o.CinsiyetId == 0
            //                            select new      //Anonim is Type
            //                            {
            //                                Isim = o.Ad,    //Takma ad verebildik (sql de as ile yapılıyor)
            //                                o.Soyad
            //                            }).ToList();
            //    //2 - Method Syntax
            //    var sonucOgrenciler4M = ogrenciler
            //                           .Where(o => o.Yas < 20 && o.CinsiyetId == 0)
            //                           .Select(x => new     //Anonim is Type
            //                           {
            //                               Isim = x.Ad,     //Takma ad verebildik (sql de as ile yapılıyor)
            //                               x.Soyad
            //                           })
            //                           .ToList();//.ToArray();

            //    // 1- Query Syntax
            //    var sonucOgrenciler5 = (from o in ogrenciler
            //                            where o.Yas < 20 && o.CinsiyetId == 0
            //                            select new OgrenciDto
            //                            {
            //                                Ad = o.Ad,    
            //                                Soyad = o.Soyad
            //                            }).ToList();
            //    //2 - Method Syntax
            //    var sonucOgrenciler5M = ogrenciler
            //                           .Where(o => o.Yas < 20 && o.CinsiyetId == 0) //x veya o farketmez nasıl istersen onu yaz.
            //                           .Select(x => new OgrenciDto    
            //                           {
            //                               Ad = x.Ad,     
            //                               Soyad = x.Soyad
            //                           })
            //                           .ToList();//.ToArray();

            //    // 1- Query Syntax
            //    var sonucOgrenciler6 = (from o in ogrenciler
            //                            where o.Yas < 20
            //                            orderby o.Ad    //Ad'a göre sıralanmış oluyor
            //                            select o).ToList();
            //    //2 - Method Syntax
            //    var sonucOgrenciler6M = ogrenciler
            //                           .Where(o => o.Yas < 20 )
            //                           .OrderBy(x => x.Ad)  //Ad'a göre sıralanmış oluyor
            //                           .ToList();//.ToArray();

            //    // 1- Query Syntax
            //    var sonucOgrenciler7 = (from o in ogrenciler
            //                            where o.Yas < 20
            //                            orderby o.Ad descending  //Ad'a göre ters sıralanmış oluyor
            //                            select o).ToList();
            //    //2 - Method Syntax
            //    var sonucOgrenciler7M = ogrenciler
            //                           .Where(o => o.Yas < 20)
            //                           .OrderByDescending(x => x.Ad )   //Ad'a göre ters sıralanmış oluyor (Query'le karşılaştırdığında method değişmiş oluyor.)
            //                           .ToList();//.ToArray();


            //    // 1- Query Syntax
            //    var sonucOgrenciler8 = (from o in ogrenciler
            //                            where o.Yas < 20
            //                            orderby o.Yas , o.Ad ,o.Soyad descending  //Önce Yaş'a göre aynı olan varsa Ad'a göre sıralar onlarda da aynı olan varsa Soyada göre tersten sıralar.
            //                            select o).ToList();

            //    //2 - Method Syntax
            //    var sonucOgrenciler8M = ogrenciler
            //                           .Where(o => o.Yas < 20)
            //                           .OrderBy(x => x.Yas)
            //                           .ThenBy(x => x.Ad)       //Thenby Orderby kullanıldıysa yazmak zorundayız 2. Orderby kullanamayız.
            //                           .ThenByDescending(x => x.Soyad)
            //                           .ToList();//.ToArray();

            //    sonucOgrenciler8M.Reverse();    //Geri Dönüş tipi yok hafıza değiştirdiği için değişkene atamamıza gerek yok.


            //    //Any();
            //    //data var mı yok mu diye kontrol yapıyoruz. 

            //    int[] yaslar = { 15, 21, 58, 44, 12, 14 };
            //    var sonuc3 = yaslar.Any();  //Burada hiç data var mı (Count != 0) aynı koşul.
            //    var sonuc4 = yaslar.Any(x => x > 100);  //100 den büyük olan var mı koşul.
            //    var sonuc5 = yaslar.Any(x => x > 50);  //50 den büyük olan var mı koşul.(return True or false)
            //    var sonuc6 = yaslar.Any(x => x == 12);  //içeride 12 olan var mı koşul.(return True or false)
            //    var sonuc7 = yaslar.Any(x => x == 60 || x == 14);

            //    var sonuc8 = yaslar.Where(x => x == 60 || x == 14)  
            //        .Any();

            //    //All();
            //    //Tüm dataların o kritere uyması gerekiyor
            //    string[] diller = { "İngilizce", "Türkçe", "Çince" };
            //    var sonuc9 = diller.All(x => x.EndsWith("e"));  //Hepsi e ile bitiyor true
            //    var sonuc10 = diller.All(x => x.EndsWith("ce"));    //Türkçe olduğundan false bütünlük ilkesine uymuyor.
            //    var sonuc11 = diller.All(x => x.Contains("e"));    //Hepsinde 'e' geçiyor Return: True
            //    var sonuc12 = diller.All(x => x.Contains("ü"));    //Hepsinde 'ü' geçmiyor Return: False


            //    var sonuc13 = ogrenciler.Any(x => x.Yas == 18);

            //    var sonuc14 = ogrenciler
            //        .Where(x => x.Yas < 20)
            //        .Count();   //Adet sayısı verir

            //    var sonuc15 = ogrenciler
            //        .Count(x => x.Yas < 20);    //Koşulu burda da kullanabilirsin.

            //    var toplamYas = yaslar.Sum();   //Bütün yaşları toplar.

            //    var toplamYas2 = ogrenciler.Sum(x => x.Yas);    //Öğrencilerin bütün yaşlarını topladı

            //    var toplamYas3 = ogrenciler
            //        .Where(x => x.Yas < 20)
            //        .Sum(x => x.Yas);

            //    //üstteki ile aynı mantık üstte yazılan kod daha mantıklı
            //    var toplamYas4 = ogrenciler
            //        .Where(x => x.Yas < 20)
            //        .Select(x=> x.Yas)
            //        .Sum(x => x);

            //    var enGencOgrenciYasi = ogrenciler
            //        .Min(x => x.Yas);   //Öğrenciler arasında en küçüğü getirir

            //    var enYasliOgrenciYasi = ogrenciler
            //        .Max(x => x.Yas);

            //    var ortalamaOgrenciYasi = ogrenciler
            //        .Average(x => x.Yas);   //Öğrencilerin ortalama yaşı


            #endregion

            var sqlAlanlar = new string[] { "Metin", "Sıla", "Ata" };
            var cSharpAlanlar = new string[] { "Betül", "Semih", "Ata" };

            var her2DErsiAlanlar = sqlAlanlar.Intersect(cSharpAlanlar).ToList();    //iki kümenin kesişimini alır.
            var sqlveyacAlanlar = sqlAlanlar.Union(cSharpAlanlar).ToList();     //aynı data gelmez tekilleştirilir. ve iki kümeyi birleştirir
            var sqlveyacAlanlarveyamicro = sqlAlanlar.Union(cSharpAlanlar).ToList();//.Union(microAlanlar).ToList();    //3 küme birleşimi de bu şekilde yapılıyor.

            var sqlveyacAlanlar2 = sqlAlanlar.Concat(cSharpAlanlar).ToList();   //Aynı data varsa tekrar etsin  //Ata 2 kere yazar.

            var sadececAlanlar = cSharpAlanlar.Except(sqlAlanlar).ToList();     //sadece c# dersi alanlar sql dersi almayanlar geldi B fark A gibi düşünülebilir. 

            var sonuc = cSharpAlanlar.Distinct().ToList();  //tekrar eden datayı göstermez 
            

        }
    }

    public class OgrenciDto //Data transferi yapılıyor ilgili prop'lar olur
    {
        public string Ad { get; set; }
        public string  Soyad { get; set; }
    }

    public class Ogrenci
    {
        public Ogrenci(int id, string ad, string soyad, string ogrenciNo, short yas, int cinsiyetId)
        {
            this.Id = id;
            Ad = ad;
            Soyad = soyad;
            OgrenciNo = ogrenciNo;
            Yas = yas;
            CinsiyetId = cinsiyetId;
        }

        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string OgrenciNo { get; set; }
        public short Yas { get; set; }
        public int CinsiyetId { get; set; }
    }


}
