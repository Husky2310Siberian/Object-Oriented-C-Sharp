namespace CollectionsApp;
/// <summary>
/// Demonstrates the usage of various collection types,
/// including List, LinkedList, Dictionary, SortedSet, Stack, and Queue.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        // dynamic array initialized with values
        var intList = new List<int>() { 1, 2, 3 , 4, 5};
        // empty doubly linked list
        var linkedList = new LinkedList<string?>();  
        // dictionary where keys are sorted 
        var words = new SortedDictionary<int , string>() {{1, "AUEB"} , {2, "OPA"}};
        // LIFO
        var stack = new Stack<string>();
        // LIFO
        var queue = new Queue<string>();
        // sorted collection of unique characters 
        var charSet = new SortedSet<char>(){'a', 'b', 'd', 'c'};
        
        /*
         * List examples
         */
        intList.Add(4);
        intList.AddRange([1,2,5]);
        intList.Add(5);
        intList.Insert(0,5);
        intList.Remove(0);
        intList.RemoveAt(2);
        intList[0] = 22;
        intList[1] = 333;
        
        intList.Sort();
        intList.Reverse();

        foreach (int element in intList)
        {
            Console.WriteLine(element);
        }
        intList.ForEach(x => Console.WriteLine(x));
        Console.WriteLine("--------");
        intList.ForEach(Console.WriteLine);
        Console.WriteLine("--------");
        
        /*
         * Linked List
         */
        var item1 = linkedList.AddFirst("Coding");
        var item2 = linkedList.AddFirst("Factory");
        var item3 = linkedList.AddFirst("AUEB");

        linkedList.First!.Next!.Next!.Value = "Athens Uni of Econ and Bus";

        foreach (var el in linkedList)
        {
            Console.WriteLine(el);
        }
        Console.WriteLine("--------");
        linkedList.ToList().ForEach(x => Console.WriteLine(x));
        Console.WriteLine("--------");
        linkedList.ToList().ForEach(Console.WriteLine);
        
        /*
         * Dictionaries
         */
        //words.Add(1,"Athens");
        words[2] = "Uni";
        words[3] = "Econ";
        words.Remove(1);
        
        if (words.ContainsKey(4))
        {
            Console.WriteLine("Contains 4");         
        }
        else
        {
            words[4] = "Business";
        }
        Console.WriteLine("--------");
        
        foreach (var keyVal in words)
        {
            Console.WriteLine($"{keyVal.Key}: {keyVal.Value}");
        }
        Console.WriteLine("--------");
        words.ToList().ForEach(x=> Console.WriteLine(x.Key + ": " + x.Value));
        
        /*
         * Sets
         */
        var charSet2 = new SortedSet<char>(){'!', '@'};
        charSet.Add('x');
        charSet.Remove('a');
        
        charSet.UnionWith(charSet2);

        foreach (var ch in charSet)
        {
            Console.WriteLine(ch + ": " + ch);
        }
        
        /*
         * Stack
         */
        stack.Push("Hello");
        stack.Push("World");
        string popped = stack.Pop();
        Console.WriteLine(popped);

        foreach (var element in stack)
        {
            Console.WriteLine(element);
        }

        /*
         * Queue
         */
        
        queue.Enqueue("car1");
        queue.Enqueue("car2");
        queue.Enqueue("car3");
        string car1 = queue.Dequeue();

        foreach (var car in queue)
        {
            Console.WriteLine(car);
        }
    }
}