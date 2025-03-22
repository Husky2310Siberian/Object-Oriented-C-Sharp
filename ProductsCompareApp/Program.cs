using ProductsCompareApp.Model;

namespace ProductsCompareApp;

internal class Program
{
    static void Main(string[] args)
    {
        List<Product> products = [new Product() { Description = "Milk", Price = 12.5, Quantity = 1},
                                    new Product() { Description = "Eggs", Price = 2.5, Quantity = 4},
                                    new Product() { Description = "Oranges", Price = 8.99, Quantity = 85},
                                    new Product() { Description = "Apples", Price = 4.99, Quantity = 40},
                                  ]; 
        products.Sort(); //sort implemented base on IComperable (Description)
        products.ForEach(Console.WriteLine);
        Console.WriteLine("------------");
        
        products.Sort((p2,p1) => p2.Price.CompareTo(p1.Price)); // sort implemented by Price DESC
        products.Reverse();
        products.ForEach(Console.WriteLine);        
        Console.WriteLine("------------");
        
        products.Sort((p1,p2) => p1.Quantity - p2.Quantity); // sort implemented by Quantity ASC
        products.ForEach(Console.WriteLine);
        
        Console.WriteLine("------------");
    }
}