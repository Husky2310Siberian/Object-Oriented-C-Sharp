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
        //filtering
        Console.WriteLine("Filtering");
        var evenNumbers2 = numbers.Where(num => num % 2 == 0);
        Console.WriteLine(string.Join(", ", evenNumbers2));
        //mapping
        Console.WriteLine("Mapping");
        var squares = numbers.Select(num => num * num).ToList();
        squares.ForEach(Console.WriteLine);
        //Reduce
        Console.WriteLine("Reduce");
        var sum = numbers.Sum();
        Console.WriteLine(sum);
        // Min - Max
        Console.WriteLine("Min - Max - Average");
        var min = numbers.Min();
        var max = numbers.Max();
        var avg = numbers.Average();
        Console.WriteLine("min:" +min);
        Console.WriteLine("max:" +max);
        Console.WriteLine("average:" +avg);
        // grater than 10
        var anyGreaterThan10 = numbers.Any(num => num >= 10);
        Console.WriteLine("Any grater than 10: " +anyGreaterThan10);
        
        Console.WriteLine("---------------");
        var allGt1 = numbers.All(num => num >= 1);
        Console.WriteLine("All grater than 1: " + allGt1);
        
        Console.WriteLine("--------------");
        var odds = numbers.Where(num => num % 2 != 0).Select(num => num * 2).ToList();
        odds.ForEach(Console.WriteLine);

    }
}