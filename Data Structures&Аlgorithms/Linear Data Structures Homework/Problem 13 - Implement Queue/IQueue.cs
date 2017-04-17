namespace Problem_13___Implement_Queue
{
    public interface IQueue<T>
    {
        void Enqueue(T value);

        T Dequeue();

        T Peek();

        void Clear();
    }
}