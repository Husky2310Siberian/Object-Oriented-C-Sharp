namespace LinqApp;

class Program
{
    static void Main(string[] args)
    {
        int [] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        /*
         * Query Syntax
         */
        // var --> IEnumerable<int>
        var allNumbers = from num in numbers select num;
        foreach (var num in allNumbers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine("------------");
        var oddNumbers = from num in numbers where num % 2 != 0 select num;
        foreach (var num in oddNumbers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine("------------");
        var evenNumbers = from num in numbers where num % 2 == 0 select num;
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine("------------");
        evenNumbers.ToList().ForEach(Console.WriteLine);
        
        Console.WriteLine("------------");
        List<int> orderedListDesc = (from num in numbers 
                                     where num % 2 != 0
                                     orderby num descending
                                     select num).ToList();
        orderedListDesc.ForEach(Console.WriteLine);
        
        /*
         * Fluent API = Method Syntax
         */
        
        
    }
}