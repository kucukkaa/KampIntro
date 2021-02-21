using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);
            //sayi1 = 30'dur

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);
            //sayilar1[0]= 999'dur

            //int,decimal,float,double,bool = değertip
            //array,class,interface =referanstip



            //bellekte stack ve heap denen iki alan var
            //değer tiplerin hepsi stack'ta olur.
            //sayilar1 arrayi stackte oluşur heap içerinde new dediğimiz anda adresi atanan bir array oluşur. ve sayilar1 atanan adresi tutar.
            //sayilar2 'de de aynı durum olur ancak adresi farklı olur ve sayilar2 de bu yeni adresi tutar.
            //sayilar1 ve sayilar2'yi eşitlediğimizde artık sayilar1 sayılar2nin referansını göstermeye başlar ve artık hep burayı gösterir. artık sayılar1in eskiden gösterdiği heapdeki adresi gösteren bir değer kalmamıştır.
            //sayilar2'nin gösterdiği referans numarasındaki array'ın bir elemanı değişince sayilar1in de gösterdiği adres aynı olduğu için sayilar1i çağırınca değişmiş değeri okuruz.
            //sayilar1'in eskiden tuttuğu refanstaki değerler garbage collector tarafından silinir. 
            
        }

    }
}
