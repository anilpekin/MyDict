using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDict
{
    class MyDictionary<T,S>
    {
        T[] keys;
        S[] values;
        T[] tempKey;
        S[] tempValue;
        public MyDictionary()
        {
            keys = new T[0];
            values = new S[0];
        }

        public void Add(T key, S value)
        {
            tempKey = keys;
            tempValue = values;
            keys = new T[keys.Length + 1];
            values = new S[values.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
                values[i] = tempValue[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
            Console.WriteLine("Added.");
        }
    }
}
