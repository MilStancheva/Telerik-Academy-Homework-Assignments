using System.Collections.Generic;

namespace Problem_4___HashTableImplementation
{
    public interface IHashTable<K, V> : IEnumerable<KeyValuePair<K, V>>
    {
        int Count { get; }

        int Capacity { get; }

        List<K> Keys { get; }

        V this[K index] { get; set; }

        void Add(K key, V value);

        bool ContainsKey(K key);

        V Find(K key);

        void Remove(K key);

        void Clear();
    }
}