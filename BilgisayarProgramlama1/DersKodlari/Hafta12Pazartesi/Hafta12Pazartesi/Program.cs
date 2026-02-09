using Hafta12Pazartesi.models;
using System.Collections;

namespace Hafta12Pazartesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Static

            //Console.WriteLine("Hello, World!");
            //Ogrenci sila = new Ogrenci("sila","soyad");
            //Ogrenci metin = new Ogrenci("metin", "soyad");
            //Ogrenci ata = new Ogrenci("ata", "soyad");

            //var ogrenciSayisi = Ogrenci.OgrenciSayisi;
            //YeniOgrenciOlustur();
            //GC.Collect();

            //Program program = new Program();
            //program.Test();

            //var universite = Ogrenci.Universite;

            ////MyUtility myUtility = new MyUtility();        //static class'ın örneği alınamaz   OOP'den çıkıp sadece fonksiyonel uygulamalar yazılır.
            #endregion



            #region ArrayList
            //ArrayList arrayList = new ArrayList();  //içerisine eleman ekledikçe kendi kapasitesini 2'nin üsleri şeklinde alınır.

            //var kapasite = arrayList.Capacity;  //4 ile başlar. 
            //var elemanSayisi = arrayList.Count;

            //arrayList.Add("Metin");
            //arrayList.Add("Sila");      //sona ekler
            //arrayList.Add("Ata");
            //arrayList.Add(1);
            //arrayList.Add(2);
            //arrayList.Add(3);
            //arrayList.Add(4);
            //arrayList.Add(new DateTime());
            //arrayList.Add(new Ogrenci("Metin", "soyad"));

            //arrayList.Remove("Metin");
            //arrayList.Remove("Sila");

            //arrayList.Insert(0,"Seçiniz");
            //arrayList.RemoveAt(0);      //şu indeks'deki veriyi sil

            //int[] yaslar = { 23, 18, 20, 10 };

            //arrayList.AddRange(yaslar);

            //arrayList.InsertRange(1,yaslar);

            //arrayList.RemoveRange(1, 3);    //verdiğimiz aralıktaki elemanları siler.

            //object?[] arrayListDizisi = arrayList.ToArray();

            ////arrayList.Clear();
            //var ilkEleman = arrayList[0];
            //if(ilkEleman is string)
            //{
            //    var ilkElemanString =  (ilkEleman as string).ToUpper();
            //}

            //var ikinciEleman = arrayList[1];
            //if (ikinciEleman is string)
            //{
            //    var ikinciElemanString = (ikinciEleman as string).ToUpper();
            //}
            //else if (ikinciEleman is int)
            //{
            //    var ikinciElemanInt = (ikinciEleman as int?) + 1;
            //}

            //for (int i = 0; i < arrayList.Count; i++)
            //{
            //    var seciliEleman = arrayList[i];
            //    Console.WriteLine(seciliEleman);
            //} 
            #endregion

            int sayi = 0;
            int sayi2 = 100;
            //var sonuc = sayi2 / sayi;
            object sayi3 = "Sila";
            //var sss = (int)sayi3;

            Ogrenci ogrenci = null;
            //var ogrenciAdi = ogrenci.Ad;

            if (sayi == 0) {
                Console.WriteLine("0'a bölünemez"); }

            try
            {
                
                //hata olabilme ihtimali olanlar
                var sonuc = sayi2 / sayi;
            }
            catch(IsubuException ex)
            {
                Console.WriteLine("Isubu tarafından bir hata oluştu");
            }
            //catch sıralamaları önemli
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Sıfıra bölmeye çalıştı");
            }
            catch (Exception ex)
            {

                //hatayı yakalamak
                Console.WriteLine("Bir hata oluştu");
                Console.WriteLine(ex.Message);
                //loglama konusunda önemli
                var hataLogu = ex.StackTrace;
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);
                if(ex.InnerException is not null)
                {
                    Console.WriteLine(ex.InnerException.Message);
                }
            }

            try
            {
                var sss = (int)sayi3;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                var ogrenciAdi = ogrenci.Ad;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            ogrenci = new Ogrenci("Metin", "soyad") { Ders = new Ders() { DersAdi = "C#"} };
            try
            {
                var ogrenciAdi = ogrenci.Ad;
                //hata oluşma ihtimali
            }
            catch(Exception ex)
            {
                Console.WriteLine("bir hata oluştu");
                // hataları yakalar
            }
            finally
            {
                Console.WriteLine("Finally çalıştı");
                //hata olsada olmasada çalışır.
            }


















        }

        public static void YeniOgrenciOlustur()
        {
            Ogrenci ulku = new Ogrenci("ulku", "soyad");
        }

        public void Test()
        {

        }
    }
}
