using PointApp.Model;

namespace PointApp;
/// <summary>
///         inheritance: Point2D and Point3D extend Point.
///         Polymorphism: Objects are stored as Point references but represent different derived types.
///         Downcasting: Required to access subclass-specific properties.
///         Heap & Stack: Objects stored in heap, references in stack.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point(1);
        Point p2 = new Point2D(1, 2);
        Point p3 = new Point3D(1, 2, 3);

        Point p4 = new Point3D()
        {
            X = 1,
            Y = 2,
            Z = 3,
        };

        p1.X = 20;
        // p2.Y = 30; Point has X , not Y , needs downcast
        ((Point2D)p2).Y = 20;
        p3.X = 40;
        ((Point3D)p3).Z = 40;
        
        p1.Move10();

        Console.WriteLine(p1);
        Console.WriteLine(p2);
        Console.WriteLine(p3);
        Console.WriteLine(p4);
        Console.WriteLine("----------------");
        List<Point> points = new List<Point>()
        {
            new Point(1) , new Point(2),
            new Point2D(2,4), new Point2D(2,77),
            new Point3D(3,5,7), new Point3D(44,55,7),
        };

        foreach (Point point in points )
        {
            Console.WriteLine(point);
        }
    }

    public static void DoPrint(Point p)
    {
        Console.WriteLine(p);
    }

    public static void MakeMove(Point p)
    {
        p.Move10();
    }

}