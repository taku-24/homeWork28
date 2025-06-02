namespace ex1;

public class MyNode<T>
{
    public T Value { get; set; }
    public MyNode<T> Next { get; set; }
    public MyNode<T> Previous { get; set; }

    public MyNode(T value)
    {
        Value = value;
    }
}
