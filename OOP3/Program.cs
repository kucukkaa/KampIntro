using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            // ihtiyacKrediManager.Hesapla();

            // TasitKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            // KonutKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();             //bir interface kendisini implemente eden bir sınıfın referansını tutabilir.
            //konutKrediManager.Hesapla();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager);

            List<IKrediManager> krediler = new List<IKrediManager>() {konutKrediManager};

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        }
    }
}
