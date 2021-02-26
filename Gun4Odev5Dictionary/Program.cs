using System;
using System.Collections.Generic;

namespace Gun4Odev5Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary= new MyDictionary<string, int>();
            myDictionary.Add("ali", 1);

            Console.WriteLine(myDictionary.LengthKeys);
            Console.WriteLine(myDictionary.LengthValues);

            myDictionary.Add("veli", 3);

            Console.WriteLine(myDictionary.LengthKeys);
            Console.WriteLine(myDictionary.LengthValues);

            myDictionary.Add("ahmet", 4);

            Console.WriteLine(myDictionary.LengthKeys);
            Console.WriteLine(myDictionary.LengthValues);

            myDictionary.Find("ahmet");
        }
    }
}
