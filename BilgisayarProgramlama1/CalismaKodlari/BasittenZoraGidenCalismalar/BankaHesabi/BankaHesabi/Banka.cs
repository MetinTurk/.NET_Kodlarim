using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaHesabi
{
    internal class Banka
    {
        private string _BankaHesabi;

        public Banka(string bankaHesabi)
        {
            _BankaHesabi = bankaHesabi;
        }

        public string BankaHesabi { get => _BankaHesabi; set => _BankaHesabi = value; }

        private double _bakiye = 0;

        public double bakiye { get => _bakiye; set => _bakiye = value; }

        public void ParaYatir()
        {
            int tutar;
            do
            {
                Console.WriteLine($"Bakiyeniz: {bakiye}");
                Console.Write("Yatırmak istediğiniz tutarı giriniz: ");
                string tutarString = Console.ReadLine();
                if (int.TryParse(tutarString, out tutar))
                {
                    bakiye += tutar;
                    Console.WriteLine("Paranız yatırıldı iyi günler.");
                    break;
                }
                else
                {
                    Console.Write("Hatalı tutar girişi lütfen tekrar deneyiniz.");
                    Console.WriteLine("---------------------------------------------");
                }
            } while (true);
        }

        public void ParaCek()
        {
            int tutar;
            do
            {
                Console.WriteLine($"Bakiyeniz: {bakiye}");
                Console.Write("Çekmek istediğiniz tutarı giriniz: ");
                string tutarString = Console.ReadLine();
                if (int.TryParse(tutarString, out tutar))
                {
                    if (bakiye >= tutar)
                    {
                        bakiye -= tutar;
                        Console.WriteLine("Para çekimi başarılı iyi günler.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen Bakiyeniziden büyük tutar girişi yapmayın.");
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı tutar girişi lütfen tekrar deneyiniz.");
                    Console.WriteLine("---------------------------------------------");
                }
            } while (true);
        }


    }
}
