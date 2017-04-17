namespace Problem_12___Implement_Stack
{
    public class CustomStackItem<T>
    {
        public T Value { get; set; }

        public CustomStackItem<T> NextItem { get; set; }
    }
}