using System;
using System.Collections.Generic;
using System.Text;

namespace Hafta11Pazartesi.Models
{
    public abstract class BaseTur
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        //public virtual void Tanit()
        //{
        //    Console.WriteLine("Bu şekilde tanıtıyorum");
        //}

        //gövdesinin nasıl yazılacığını bilmediğimiz, kalıtım alındığında yazabildiğimiz fonks.
        //override etmek zorundasın.
        public abstract void Tanit();

    }

    internal class Marka : BaseTur 
    {
        public override void Tanit()
        {
                Console.WriteLine("Markayı tanıtıyor");
        }

       
    }

    public class Model : BaseTur
    {
        public int Id { get; set; }
        public string Ad { get; set; }

        public override void Tanit()
        {
            Console.WriteLine("Modeli tanıtıyor");
        }
    }
}
