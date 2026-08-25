using System;
using System.Collections.Generic;
using System.Text;

namespace ChatApplicationMessageStore
{
    public class HashMapEntry<T>
    {
        public int Key;
        public T Value;
        public HashMapEntry<T> Next;
        public HashMapEntry(int key, T value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }

    public class HashMap<T>
    {
        private HashMapEntry<T>[] buckets;
        private int size;
        public HashMap(int capacity)
        {
            buckets = new HashMapEntry<T>[capacity];
            size = 0;
        }

        private int GetIndex(int key)
        {
            int index = key % buckets.Length;
            if (index < 0)
            {
                index = index + buckets.Length;
            }
            return index;
        }

        public void Put(int key, T value)
        {
            int index = GetIndex(key);
            HashMapEntry<T> current = buckets[index];
            while (current != null)
            {
                if (current.Key == key)
                {
                    current.Value = value;
                    return;
                }
                current = current.Next;
            }

            HashMapEntry<T> newEntry = new HashMapEntry<T>(key, value);
            newEntry.Next = buckets[index];
            buckets[index] = newEntry;
            size++;
        }

        public T Get(int key)
        {
            int index = GetIndex(key);
            HashMapEntry<T> current = buckets[index];
            while (current != null)
            {
                if (current.Key == key)
                {
                    return current.Value;
                }
                current = current.Next;
            }
            return default(T);
        }

        public bool ContainsKey(int key)
        {
            int index = GetIndex(key);
            HashMapEntry<T> current = buckets[index];
            while (current != null)
            {
                if (current.Key == key)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public List<T> GetAllValues()
        {
            List<T> values = new List<T>();
            for (int i = 0; i < buckets.Length; i++)
            {
                HashMapEntry<T> current = buckets[i];
                while (current != null)
                {
                    values.Add(current.Value);
                    current = current.Next;
                }
            }
            return values;
        }
        public int Count
        {
            get { return size; }
        }
    }
}
