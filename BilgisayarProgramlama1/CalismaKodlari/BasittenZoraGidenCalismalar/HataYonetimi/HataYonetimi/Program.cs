namespace HataYonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exception Handling

            try
            {
                Console.Write("1. Sayıyı giriniz: ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("2. Sayıyı giriniz: ");
                int sayi2 = Convert.ToInt32(Console.ReadLine());        //TryParse

                var sonuc = sayi1 / sayi2;

                Console.WriteLine(sonuc);

            }
            catch (FormatException)
            {
                Console.WriteLine("sayısal bilgileri düzgün giriniz");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Sayı 2 sıfır olmamalıdır");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bir hata oluştu");
                Console.WriteLine(ex.Message);
            }

            int sayi = 10;
            if(sayi > 5)
            {
                throw new Exception("sayı 5 den büüyk olamaz");
            }


            

        }

        static void ParolaKontrol(string password)
        {
            if(password.Length <= 6 && password.Length >= 10){
                throw new Exception("parola 6-10 karekter aralığında olmalıdır");
            }

            if (!password.Any(char.IsDigit))
            {
                throw new Exception("parola en az bir rakam içermelidir.");
            }
            if (!password.Any(char.IsLetter))
            {
                throw new Exception("parola en az bir harf içermelidir.");
            }

            
        }
    }
}
