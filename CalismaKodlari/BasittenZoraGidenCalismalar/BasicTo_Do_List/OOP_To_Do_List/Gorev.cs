using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_To_Do_List
{
    public class Gorev
    {
        private string gorevi;
        private bool durum;

        public Gorev(string gorevi)
        {
            this.gorevi = gorevi;
        }

        public string Gorevi { get => gorevi; set => gorevi = value; }
        public bool Durum { get => durum; set => durum = value; }

        static public void CizgiBas()
        {
            Console.WriteLine("-------------------------------------");
        }

        static public bool EkranaYaz(List<Gorev> liste)
        {
            {
                try
                {
                    if (!(String.IsNullOrEmpty(liste[0].Gorevi)))
                    {
                        var i = 0;
                        foreach (var item in liste)
                        {
                            i++;
                            if (item.Durum)
                            {
                                Console.WriteLine($"[X]  {i}. Görev : {item.Gorevi}");
                            }
                            else
                            {
                                Console.WriteLine($"[ ]  {i}. Görev : {item.Gorevi}");
                            }
                        }
                    }
                    return true;
                }
                catch
                {
                    Console.WriteLine("Listeniz Boş Lütfen Görev ekleyiniz.");
                    return false;
                }
            }
        }

        /*
        public Gorev(string gorevi) {
        var _gorevi = gorevi;
        bool durum = false;
        }
        */
        /*

        public string Gorevi{
            get
            {
                return gorevi;
            }
            set
            {
                 = value;
            }
        }
        public bool 
        */

    }
}
