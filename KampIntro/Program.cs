using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            //değer tutucu,alias=kategorietiketi,öğrencisayisi,faiz oranı
            
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmismi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            //
            //
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artış");
            }
            else
            {
                Console.WriteLine("değişmedi");
            }
        }
    }
}
