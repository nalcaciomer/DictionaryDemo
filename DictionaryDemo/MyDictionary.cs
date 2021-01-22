using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryDemo
{
    class MyDictionary<TKey,TValue>
    {
        TKey[] keys;
        TValue[] values;
        bool canAdd = true;
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            foreach (var item in keys)
            {
                if (item.Equals(key))
                {
                    Console.WriteLine("Eklemek istediğiniz anahtar zaten sözlükte mevcut.Lütfen başka bir anahtar deneyiniz.");
                    canAdd = false;
                    break;
                }
            }
            if (canAdd)
            {
                TKey[] tempKeys = keys;
                TValue[] tempValues = values;
                keys = new TKey[tempKeys.Length + 1];
                values = new TValue[tempValues.Length + 1];
                for (int i = 0; i < tempKeys.Length; i++)
                {
                    keys[i] = tempKeys[i];
                    values[i] = tempValues[i];
                }
                keys[keys.Length - 1] = key;
                values[values.Length - 1] = value;
            }
        }
        public int Length()
        {
            return keys.Length;
        }
    }
}
