using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionaries
{
    class MyDictionary<K,V>
    {
        K[] keys;
        V[] values;
        
        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
            
        }

        public void Add(K key, V value)
        {
            K[] tempKeys = keys;
            V[] tempValues = values;

            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }
            for (int sayac = 0; sayac < tempValues.Length; sayac++)
            {
                values[sayac] = tempValues[sayac]; 
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
          
        }
        public K[] Key
        {
            
            get { return keys; }
        }
        public V[] Value
        {
            get {return values ;}
        }
        public int Length
        {
            get { return keys.Length; }
        }

    }
}
