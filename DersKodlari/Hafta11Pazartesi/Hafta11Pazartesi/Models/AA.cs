using System;
using System.Collections.Generic;
using System.Text;

namespace Hafta11Pazartesi.Models
{
    //seald = kalıtım alınamaz.
    public sealed class AA
    {
        
    }
    //sınıfın kalıtımı alınamaz (seald)
    //public class BB : AA
    //{

    //}

    public class BB
    {
        public virtual void Test()
        {

        }
    }
    public class CC : BB
    {
        //bu fonsk. kalıtım alınan sınıflarda değiştirilemez yapar.
        public sealed override void Test() 
        {
            
        }
    }
    public class DD : CC
    {
        //override edemeyiz çünkü bir üst sınıfta (seald) anahtarı kullanılmış.
        //public override void Test()
        //{

        //}
        //tek yolu ama tercih etmiyoruz.
        public new void Test()
        {

        }

    }

}
