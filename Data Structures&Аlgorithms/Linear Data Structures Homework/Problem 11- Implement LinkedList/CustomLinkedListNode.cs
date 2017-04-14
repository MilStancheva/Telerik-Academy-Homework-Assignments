namespace Problem_11__Implement_LinkedList
{
    public class CustomLinkedListNode<T>
    {
        public T Value { get; set; }

        public CustomLinkedListNode<T> Previous { get; set; }

        public CustomLinkedListNode<T> Next { get; set; }
    }
}