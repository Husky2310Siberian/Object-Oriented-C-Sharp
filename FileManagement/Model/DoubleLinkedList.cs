namespace FileManagement.Model;

internal class DoubleLinkedList<T>
{
    public GenericNode<T>? Head { get; set; } = null;
    public GenericNode<T>? Tail { get; set; } = null;
    
    public void InsertFirst(T t)
    {
        GenericNode<T>? tmp = new()
        {
            Value = t,
            Count = 1,
            Next = Head,
            Previous = null,
        };
        Head = tmp;
        if (IsEmpty())
        {
            Tail = tmp;
        }
    }

    public void InsertLast(T t)
    {
        if (IsEmpty())
        {
            InsertFirst(t);
            return;
        }

        GenericNode<T>? tmp = new()
        {
            Value = t,
            Count = 1,
            Next = null,
            Previous = Tail,
        };
        Tail!.Next = tmp;
        Tail = tmp;
    }

    public void Traverse(int totalChars)
    {
        if (IsEmpty())
        {
            Console.WriteLine("List is empty");
            return;
        }
        GenericNode<T>? node = Head!;
        while (node != null)
        {
            Console.WriteLine($"Value: {node.Value} Frequency: {(node.Count / (double) totalChars):P2}");
            node = node.Next!;
        }
    }

    public GenericNode<T>? GetPosition(T t)
    {
        GenericNode<T>? node = Head!;
        while (node != null)
        {
            if (node.Value!.Equals(t))
            {
                return node;
            }
            node = node.Next!;
        }
        return null;
    }

    public void IncreaseCount(GenericNode<T>? node)
    {
        if (node == null)
            return;
        node.Count++;
    }

    public bool IsEmpty()
    {
        return Head == null && Tail == null;
    }

}