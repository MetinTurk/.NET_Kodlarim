namespace Hafta11Pazartesi.Models
{

    public interface IBase
    {

    }
    public interface IA :IBase
    {
        void Test();
    }
    public interface IB : IA
    {
        int Deneme(int sayi);
    }

    public class A : IA
    {
        public void Test()
        {
            throw new NotImplementedException();
        }
    }

    public class B : IB
    {
        public int Deneme(int sayi)
        {
            throw new NotImplementedException();
        }

        public void Test()
        {
            throw new NotImplementedException();
        }
    }
}
