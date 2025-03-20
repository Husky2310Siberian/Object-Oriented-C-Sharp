namespace InterfacesApp.Model;

public abstract class AbstractPoint : IMoveable
{
    public int X { get; set; }

    public AbstractPoint() { }

    protected AbstractPoint(int x)
    {
        X = x;
    }

    public virtual void Move10()
    {
        X += 10;
        Console.WriteLine("Moved by 10 units");
    }

    public virtual void Move15()
    {
        X += 15;
        Console.WriteLine("Moved by 15 units");
    }
}