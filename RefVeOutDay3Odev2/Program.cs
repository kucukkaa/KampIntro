using System;

namespace RefVeOutDay3Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 15; //ref keyword ile göndereceğimiz için değer atadık
            int b = 16;
            int d = 20;
            int c; // out keywordü ile göndereceğimiz için değer atamadık sadece tanımladık.

            //ref keyword ile
            Toplama(ref a, b);

            //out keyword ile
            Carpma(out c, d);
        }


        public static void Toplama(ref int a, int b)
        {
            //a = 25; ref keyword ile gönderildiği için içerde değer ataması şart değil
            var result = a + b;
            Console.WriteLine(result);
        }

        public static void Carpma(out int c, int d)
        {
            c = 45; // out keyword ile geldiği için ve dışarıda değer atanmadığı için kullanmadan önce değer atadık.
            var result = c * d;
            Console.WriteLine(result);
        }
    }
       
}
