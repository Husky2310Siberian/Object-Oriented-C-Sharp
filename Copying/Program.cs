using Copying.Model;

namespace Copying;

class Program
{
    static void Main(string[] args)
    {
        Student original = new Student(1, "John", "Doe", new Address("Main St", "123", "10001"));

        Student shallowCopy = original.GetShallowCopy();
        Student deepCopy = original.GetDeepCopy();

        // Modifying the address in shallowCopy affects original
        shallowCopy.Address.StreetName = "Changed Street";  
        Console.WriteLine(original.Address.StreetName);  // Output: "Changed Street"

        // Modifying the address in deepCopy does NOT affect original
        deepCopy.Address.StreetName = "New Street";  
        Console.WriteLine(original.Address.StreetName);  // Output: "Changed Street"
        Console.WriteLine(deepCopy.Address.StreetName);  // Output: "New Street"

    }
}