using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4___HashTableImplementation
{
    public class HashTable<K, V> : IHashTable<K, V>, IEnumerable<KeyValuePair<K, V>>
    {
        private const int InitialCapacity = 16;
        private string keyAlreadyExistsExceptionMessage = "Key already exists.";
        private string keyDoesNotExistsInTheHashTableExceptionMessage = "The key is not present in the hash table";
        private string itemWithTheKeyIsNotFoundExceptionMessage = "There is no item with the provided key";
        private LinkedList<KeyValuePair<K, V>>[] values;

        public HashTable()
        {
            this.values = new LinkedList<KeyValuePair<K, V>>[InitialCapacity];
        }

        public int Count
        {
            get;
            private set;
        }

        public int Capacity
        {
            get
            {
                return this.values.Length;
            }
        }

        public List<K> Keys
        {
            get
            {
                var keys = this.GetKeys();                
                return keys;
            }
        }

        public V this[K key]
        {
            get
            {
                return this.Find(key);
            }
            set
            {
                var hash = this.HashKey(key);

                if (this.values[hash] != null)
                {
                    this.values[hash] = new LinkedList<KeyValuePair<K, V>>();
                    var pair = new KeyValuePair<K, V>(key, value);
                    this.values[hash].AddLast(pair);
                }
                else
                {
                    throw new IndexOutOfRangeException(keyDoesNotExistsInTheHashTableExceptionMessage);

                }
            }
        }

        public void Add(K key, V value)
        {
            var hash = this.HashKey(key);

            if (this.values[hash] == null)
            {
                this.values[hash] = new LinkedList<KeyValuePair<K, V>>();
            }

            var alreadyContainsKey = this.values[hash].Any(p => p.Key.Equals(key));

            if (alreadyContainsKey)
            {
                throw new ArgumentException(keyAlreadyExistsExceptionMessage);
            }

            var pair = new KeyValuePair<K, V>(key, value);
            this.values[hash].AddLast(pair);
            this.Count++;

            if (this.Count >= 0.75 * this.Capacity)
            {
                this.ResizeAndReAddValues();
            }
        }

        public void Clear()
        {
            this.values = null;
            this.Count = 0;
        }

        public bool ContainsKey(K key)
        {
            var hash = this.HashKey(key);

            if (this.values[hash] == null)
            {
                return false;
            }

            var pairs = this.values[hash];

            return pairs.Any(pair => pair.Key.Equals(key));
        }

        public V Find(K key)
        {
            var hash = this.HashKey(key);

            if (this.values[hash] == null)
            {
                throw new ArgumentException(itemWithTheKeyIsNotFoundExceptionMessage);
            }

            var pairs = this.values[hash];
            var value = pairs.Where(pair => pair.Key.Equals(key))
                .Select(pair => pair.Value)
                .First();

            return value;
        }

        public void Remove(K key)
        {
            var hash = this.HashKey(key);

            if (this.values[hash] == null)
            {
                throw new ArgumentException(itemWithTheKeyIsNotFoundExceptionMessage);
            }

            var pairs = this.values[hash]
                .FirstOrDefault(pair => pair.Key.Equals(key));

            this.values[hash].Remove(pairs);
            this.Count--;
        }

        public IEnumerator<KeyValuePair<K, V>> GetEnumerator()
        {
            foreach (var valueCollection in this.values)
            {
                if (valueCollection != null)
                {
                    foreach (var value in valueCollection)
                    {
                        yield return value;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private int HashKey(K key)
        {
            var hash = key.GetHashCode();
            hash %= this.Capacity;
            hash = Math.Abs(hash);

            return hash;
        }

        private void ResizeAndReAddValues()
        {
            var cachedValues = this.values;

            this.values = new LinkedList<KeyValuePair<K, V>>[this.Capacity * 2];

            this.Count = 0;
            foreach (var valueCollection in cachedValues)
            {
                if (valueCollection != null)
                {
                    foreach (var value in valueCollection)
                    {
                        this.Add(value.Key, value.Value);
                    }
                }
            }
        }

        private List<K> GetKeys()
        {
            var keys = new List<K>();
            foreach (var keyCollection in this.values)
            {
                if (keyCollection != null)
                {
                    foreach (var pair in keyCollection)
                    {
                        keys.Add(pair.Key);
                    }
                }
            }

            return keys;
        }
    }
}