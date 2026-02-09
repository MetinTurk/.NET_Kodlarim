using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace FinalOncesiSonAlistirma.AkilliFabrika
{
    public enum CihazDurumu
    {
        Aktif,
        Pasif,
        Ariza,
        Bakim
    }
    public class CihazYanitVermiyorException: Exception 
    {
        public CihazYanitVermiyorException(string message) : base(message)
        {
            
        }
    }

    public abstract class Cihaz
    {
        public Guid SeriNo { get;  private set; }
        public CihazDurumu Durum { get; set; }
        public Cihaz()
        {
            this.SeriNo = Guid.NewGuid();
            this.Durum = CihazDurumu.Pasif; 
        }
        public abstract void Calistir();
        public virtual void Kapat()
        {
            Console.WriteLine("Cihaz Kapanıyor...");
            this.Durum = CihazDurumu.Pasif;
        }
    }

    public interface IVeriSaglayici<T> where T : struct
    {
        T VeriOku();
        T VeriKalibreEt(T referansDeger);
    }

    public class SicaklikSensoru : Cihaz , IVeriSaglayici<double>
    {
        public override void Calistir()
        {
            Console.WriteLine("Sensöt ısınıyor");
            this.Durum = CihazDurumu.Aktif;
        }

        public double VeriKalibreEt(double referansDeger)
        {
            throw new NotImplementedException();
        }

        public double VeriOku()
        {
            if(this.Durum == CihazDurumu.Ariza)
            {
                throw new CihazYanitVermiyorException("FIRLADIM");
            }
            else
            {
                Random random = new Random();
                return (double)random.Next(20, 80);
            }
        }
    }
    public class UretimSayaci : Cihaz, IVeriSaglayici<double>
    {
        static double sayac = 0;
        public override void Calistir()
        {
            this.Durum = CihazDurumu.Aktif;
        }

        public double VeriKalibreEt(double referansDeger)
        {
            throw new NotImplementedException();
        }

        public double VeriOku()
        {
            sayac++;
            return sayac;
        }

    }

    public class CihazYoneticisi<T> where T : Cihaz , new()
    {
        public List<T> Envanter;
        public CihazYoneticisi()
        {
            Envanter = new List<T>();
        }

        public T YeniCihazEkle()
        {
            T nesne = new T();
            Envanter.Add( nesne );
            return nesne;
        }

        public void TumunuKapat() 
        {
            foreach (var item in Envanter)
            {
                item.Kapat();
            }
        }
    }

}
