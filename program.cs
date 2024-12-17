namespace arayuz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Polis polis = new Polis();

            polis.durum = "evet";
            polis.boy = 185;

            İtfaiye itfaiye  = new İtfaiye();

            itfaiye.yas = 25;



        }
    }

    interface IHuman
    {
        int boy { get; set; }
        int yas { get; set; }
        int kilo { get; set; }

    }

    class Polis:IHuman
    {
        public int boy { get; set; }
        public int yas { get; set; }
        public int kilo { get; set; }
        public string durum { get; set; }

    }

    class İtfaiye : IHuman
    {
        public int boy { get; set; }
        public int yas { get; set; }
        public int kilo { get; set; }

    }
}
