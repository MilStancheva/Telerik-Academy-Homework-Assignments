using System;
using System.Collections.Generic;
using System.Collections;

using Problem_4___HashTableImplementation;

namespace Problem_5___HashSetImplementation
{
    public class HashedSet<T> : IHashedSet<T>, IEnumerable<T>
    {
        private IHashTable<int, T> values;
        private int count;

        public HashedSet()
        {
            this.values = new HashTable<int, T>();
            this.count = 0;
        }

        public int Count
        {
            get
            {
                return this.count; 
            }
        }

        public void Add(T value)
        {
            int key = this.HashKey(value);
            this.values.Add(key, value);
            this.count++;
        }

        public void Clear()
        {
            this.values = null;
            this.count = 0;
        }

        public bool Contains(T value)
        {
            int key = this.HashKey(value);
            return this.values.ContainsKey(key);
        }

        public void Remove(T value)
        {
            int key = this.HashKey(value);
            this.values.Remove(key);
            this.count--;
        }

        public IHashedSet<T> Intersect(HashedSet<T> otherSet)
        {
            var intersectSet = new HashedSet<T>();

            foreach (var item in this.values)
            {
                foreach (var otherItem in otherSet.values)
                {
                    if (item.Value.Equals(otherItem.Value))
                    {
                        intersectSet.Add(otherItem.Value);
                    }
                }
            }

            return intersectSet;
        }

        public IHashedSet<T> Union(HashedSet<T> otherSet)
        {
            var unionSet = new HashedSet<T>();

            foreach (var item in this.values)
            {
                unionSet.Add(item.Value);
            }

            foreach (var item in otherSet.values)
            {
                if (!unionSet.Contains(item.Value))
                {
                    unionSet.Add(item.Value);
                }
            }

            return unionSet;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this.values)
            {
                yield return item.Value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private int HashKey(T value)
        {
            var hash = value.GetHashCode();
            hash %= this.values.Capacity;
            hash = Math.Abs(hash);

            return hash;
        }
    }
}