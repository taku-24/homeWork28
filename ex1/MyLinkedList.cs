namespace ex1;

public class MyLinkedList<T>
{
    private MyNode<T> head;
    private MyNode<T> tail;
    private int count;

    public MyNode<T> First => head;
    public MyNode<T> Last => tail;
    public int Count => count;
    
    public void Add(T element)
    {
        MyNode<T> newNode = new MyNode<T>(element);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            newNode.Previous = tail;
            tail = newNode;
        }

        count++;
    }
    public T RemoveFirst()
    {
        if (head == null)
        {
            throw new InvalidOperationException("Невозможно удалить элемент, так как список пуст.");
        }

        T removedValue = head.Value;
        if (head == tail) 
        {
            head = null;
            tail = null;
        }
        else
        {
            head = head.Next;
            head.Previous = null;
        }

        count--;
        return removedValue;
    }
    
    public T RemoveLast()
    {
        if (tail == null)
        {
            throw new InvalidOperationException("Невозможно удалить элемент, так как список пуст.");
        }

        T removedValue = tail.Value;
        if (head == tail)
        {
            head = null;
            tail = null;
        }
        else
        {
            tail = tail.Previous;
            tail.Next = null;
        }

        count--;
        return removedValue;
    }
    
    public T GetByIndex(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Индекс выходит за границы списка.");
        }

        MyNode<T> current = head;
        for (int i = 0; i < index; i++)
        {
            current = current.Next;
        }
        return current.Value;
    }
}