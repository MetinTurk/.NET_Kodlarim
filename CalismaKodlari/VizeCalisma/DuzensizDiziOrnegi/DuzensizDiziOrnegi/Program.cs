namespace DuzensizDiziOrnegi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hamVeri = "CNTR:101-Urun:5_Risk:2_ACIL , CNTR:102-Urun:3_Risk:1_YAVAŞ | CNTR:204-Urun:4_Risk:0_NORMAL | CNTR:307-Urun:6_Risk:2_KRITIK";
            string[] konteynerlar = hamVeri.Split('|');
            int[][] riskDurumlari = new int[3][];
            string[] urunler;
            for (int i = 0; i < konteynerlar.Length; i++)
            {
                urunler = konteynerlar[i].ToString().Split(",");
                riskDurumlari[i] = new int[urunler.Length];
                string[] duzenliVeri = urunler[i].Split("_");
                int riskKodu = int.Parse(duzenliVeri[1].Substring(duzenliVeri[1].Length - 1 , 1).ToString());
                for (int j = 0; j < urunler.Length; j++)
                {
                    
                }

            }
        }
    }
}
