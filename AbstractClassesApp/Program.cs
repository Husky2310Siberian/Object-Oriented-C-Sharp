using AbstractClassesApp.Model;

namespace AbstractClassesApp;
using AbstractClassesApp;
class Program
{
    static void Main(string[] args)
    {
        Cat cat1 = new()
        {
            Id = 1,
            Name = "Lion",
            Age = 5
        };
        
        cat1.Eat();
        cat1.Speak();
    }
}