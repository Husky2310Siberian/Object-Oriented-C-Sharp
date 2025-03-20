namespace InterfacesApp.Model;

internal class Point2D : AbstractPoint , IMoveable
{
    public int Y { get; set; }

    public override void Move10()
    {
        base.Move10();
        Y += 10;
    }

    public override void Move15()
    {
        base.Move15();
        Y += 15;
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}