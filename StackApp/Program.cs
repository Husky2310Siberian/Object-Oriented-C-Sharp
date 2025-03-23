using StackApp.Exceptions;
using StackApp.Model;

namespace StackApp;

class Program
{
    static void Main(string[] args)
    {
        CFStack stack1 = new (50);
        try
        {
            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);
            stack1.Push(4);
            stack1.Push(5);
            stack1.Traverse();
            int popped = stack1.Pop();
            Console.WriteLine($"Popped: {popped}");
        }
        catch (StackIsEmptyException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (StackIsFullException e)
        {
            Console.WriteLine(e.Message);
        }
        stack1.Traverse();
    }
}