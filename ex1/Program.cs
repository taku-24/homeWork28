namespace ex1;

public class Program
{
    public static void Main(string[] args)
    {
        MyLinkedList<int> myList = new MyLinkedList<int>();
        
        myList.Add(10);
        myList.Add(20);
        myList.Add(30);
        Console.WriteLine($"Количество после добавления: {myList.Count}");
        
        try
        {
            int secondElement = myList.GetByIndex(1); 
            Console.WriteLine($"Элемент с индексом 1: {secondElement}");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        
        try
        {
            int removed = myList.RemoveFirst();
            Console.WriteLine($"Удалён первый элемент: {removed}");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }

        Console.WriteLine($"Количество после удаления: {myList.Count}");
        
        try
        {
            int removedLast = myList.RemoveLast();
            Console.WriteLine($"Удалён последний элемент: {removedLast}");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }

        Console.WriteLine($"Количество в финале: {myList.Count}");
    }
}