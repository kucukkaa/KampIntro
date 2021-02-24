using System;
using System.Collections.Generic;

namespace Gun4Odev3Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");

            MyList<string> sehirler2 = new MyList<string>();
            Console.WriteLine(sehirler2.Count);
            sehirler2.Add("Ankara");
            Console.WriteLine(sehirler2.Count);
        }
    }

    class MyList<T>//generic class
    {
        T[] _array;
        T[] _tempArray;

        public MyList()
        {
            _array = new T[0];
        }
        
        
        public void Add(T item) 
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];

            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;
        }

        

        public int Count
        {
            get { return _array.Length; }
            
        }

    }
}
