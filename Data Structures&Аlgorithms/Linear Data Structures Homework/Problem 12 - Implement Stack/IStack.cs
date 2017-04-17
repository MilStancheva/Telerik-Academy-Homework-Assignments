namespace Problem_12___Implement_Stack
{
    public interface IStack<T>
    {
        int Count { get; }
        
        bool IsEmpty();

        void Push(T item);

        T Pop();

        T Peek();
    }
}