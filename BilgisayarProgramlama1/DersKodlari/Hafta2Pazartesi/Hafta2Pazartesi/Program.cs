namespace Hafta2Pazartesi
{
    internal class Program
    {
        static void Main(string[] args) // Static Main methodu olmak zorunda. 
        {
            Console.WriteLine("Hello, World!");

            // Yorum satırı oluşturma (//)

            /*
             *Çoklu 
             * Yorum Satırı
             * Oluşturma
             * (/_*  *_/)
             */

            //(oto yorum satırı yapma : ctrl + k + c)
            //(oto yorum satırı kaldırma: ctrl + k + u)


            
            #region Region Örneği
            Console.WriteLine("Merhaba");
            Console.WriteLine("Dünya");
            #endregion


            #region Kısayol Region (ctrl + k + s)
            Console.WriteLine("Merhaba");
            Console.WriteLine("Dünya"); 
            #endregion

            Console.WriteLine("Merhaba");
            Console.WriteLine("Dünya");
            Console.WriteLine("Merhaba");
            Console.WriteLine("Dünya");

            //todo: Buraya SMS gönderme kodu eklenecek


            // c# case sensitive (büyük küçük harf duyarlılığı)
            // c# type safe (tip güvenliği: int tanımlandıktan sonra değiştirilemez)

            short ay = 11;
            int yas = 39;

            int sicaklik = 23;
            //int basi&%+nc = 12;       

            // değişken ismi tanımlarken
            // 1. özel karakter kullanamazsın sadece (_) hariç 
            // 2. Sayısal bir ifade ile başlayamayız.
            // 3. c# da olan bir keyword değişken ismi olamaz
            // 4. aynı scope içerisinde aynı isimle birden fazla değişken tanımlanamaz.

            //int 2yas = 33;
            int yas2 = 45;
            int yas_degeri = 22;


            //short ay = 34;    (aynı scope içerisinde birden fazla tanımlama yapılamaz)
            ay = 34;
            int Ay = 44;    //isimlendirme kurallarına göre yanlış

            double net = 87.9;
            //int net2 = 89.1; hatalı

            char ayirici = 'A';
            //char ayirici2 = "A"; hatalı


            string ad = "Sıla";
            string ad2 = "e";
            //string ad3 = 'e'; hatalı
            
        }
    }
}
