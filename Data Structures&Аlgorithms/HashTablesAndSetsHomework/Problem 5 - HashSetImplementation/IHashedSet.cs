using System.Collections.Generic;

namespace Problem_5___HashSetImplementation
{
    public interface IHashedSet<T> : IEnumerable<T>
    {
        int Count { get; }

        void Add(T value);

        bool Contains(T value);

        void Remove(T value);

        IHashedSet<T> Union(HashedSet<T> otherSet);

        IHashedSet<T> Intersect(HashedSet<T> otherSet);

        void Clear();
    }
}