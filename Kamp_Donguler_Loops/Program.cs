using System;

namespace Kamp_Donguler_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] {"ders1","ders2","ders3","ders4" };
            
            
            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

        }
    }
}
