namespace InterfacesApp.Model;

internal class Point : AbstractPoint , IMoveable
{
    public Point() { }

    public Point(int x) : base(x) { }
    
}