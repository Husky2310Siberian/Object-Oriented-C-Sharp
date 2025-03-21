namespace AnimalSaysHi;
/// <summary>
/// Implements multiple interfaces
/// </summary>
public class DemoClass : IFirstInterface , ISecondInterface
{
    public void FirstMethod()
    {
        Console.WriteLine("FirstMethod says hello");
    }
    
    public void SecondMethod()
    {
        Console.WriteLine("SecondMethod says hello");
    }
}