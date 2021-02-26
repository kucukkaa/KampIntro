using System;
using System.Collections.Generic;
using System.Text;

namespace Gun4Odev5Dictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] tempKeys = new TKey[0];
            TValue[] tempValues = new TValue[0];

            tempKeys = keys;
            tempValues = values;

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }

            for (int i = 0; i < tempValues.Length; i++)
            {
                values[i] = tempValues[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

        public void Find(TKey key)
        {
            int keyIndex = Array.IndexOf(keys, key);

            Console.WriteLine(values[keyIndex]);       
        }



        public int Length
        {
            get { return values.Length; }
        }

        //public int LengthKeys
        //{
        //    get { return keys.Length; }
        //}
    }
}
