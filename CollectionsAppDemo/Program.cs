namespace CollectionsAppDemo;

class Program
{
    static void Main(string[] args)
    {
        /*
         * List<T>
         * Need fast indexed access
         */
        var studentsList = new List<string> {"Alice" , "Bob", "Charlie" };
        studentsList.Add("David");
        studentsList.Insert(4, "Ermolaos");
        Console.WriteLine(string.Join(", ", studentsList));
        studentsList.Remove("Bob");
        Console.WriteLine(string.Join(", ", studentsList));
        Console.WriteLine("---------------");
        /*
         * LinkedList<T>
         * Need fast insertions/removals (anywhere)
         */
        var actions = new LinkedList<string>();
        actions.AddFirst("Open file");
        actions.AddLast("Edit file");
        actions.AddLast("Save file");

        if (actions.Count > 0)
        {
            Console.WriteLine("The first action is {0}:", actions.First.Value);
            Console.WriteLine("The last action is {0}:", actions.Last.Value);

            Console.WriteLine("The linkedlist contains");
            foreach (String action in actions)
                Console.WriteLine("{0}", action);
        }
        else
        {
                Console.WriteLine("There is nothing to save");    
        }
        Console.WriteLine("---------------");
        
        /*
         * Dictionary<TKey, TValue>
         * Need fast lookups by key
         */
        var phoneBook = new Dictionary<string, string>()
        { { "Alice", "+35987654321" }, { "Bob", "+35987654322" }, };
        
        Console.WriteLine(phoneBook["Alice"]);
        Console.WriteLine("---------------");
        
        /*
         * SortedDictionary<TKey, TValue>
         * Need a sorted dictionary
         */
        var studentGrades = new SortedDictionary<string, double>
        { { "Alice", 9.99 }, { "Bob", 8.99 }, { "Charlie", 5.19 }, };
        Console.WriteLine(studentGrades["Alice"]);
        Console.WriteLine("---------------");
        
        /*
         * SortedSet<T>
         * Need a sorted, unique collection
         */
        var highScores = new SortedSet<int>
        { 100, 234, 444 };
        highScores.Add(500);
        Console.WriteLine("---------------");
        
        /*
         * Stack<T>
         * Need LIFO (Last-In, First-Out) behavior
         */
        var browserHistory = new Stack<string>();
        browserHistory.Push("www.C#.com");
        browserHistory.Push("www.Python.com");
        browserHistory.Pop();
        Console.WriteLine("---------------");
        
        /*
         * Queue<T>
         * Need FIFO (First-In, First-Out) behavior
         */
        var customerQueue = new Queue<string>();
        customerQueue.Enqueue("Siberian1");
        customerQueue.Enqueue("Siberian2");
        customerQueue.Dequeue();
        Console.WriteLine("---------------");
        Console.WriteLine("---------------");
        
        
    }
}