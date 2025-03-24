namespace LinkListDemo.Model;
/// <summary>
/// Defines the necessary properties of an element in our linked list
/// and provides the constructor for creating new nodes
/// </summary>
/// <typeparam name="T"></typeparam>
public class DoublyLinkedList<T>
{
    public class Node
    {
        public T Value { get; set; }
        public Node Previous { get; set; }
        public Node Next { get; set; }
        public Node(T t)
        {
            Value = t;
            Previous = null;
            Next = null;
        }
    }
    //the front of the list, is a Node variable called _head.
    private Node? _head;
    
    public Node First => _head;
    public Node Last
    {
        get
        {
            Node? node = GetLastNode(); return node;
        }
    }
    
    public Node Next => _head.Next;
    public Node Previous => _head.Previous;
    
    //[SerializeField]
    private int _count;

    public int Count
    {
        get
        {
            if (_count < 0)
            {
                _count = 0;
            }
            return _count;
        }
        private set
        {
            _count = value;
        }
    }

    private Node GetLastNode()
    {
        Node node = _head;
        while (node.Next != null)
        {
            node = node.Next;
        }
        return node;
    }
}