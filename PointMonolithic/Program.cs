using PointMonolithic.Model;

namespace PointMonolithic;

class Program
{
    static void Main(string[] args)
    {
        Point p1 = new() { X = 100 };
        Point p2 = new() { X = 2 };
        Point p3 = new() { X = 3 };
        p1.InsertPoint();
        p2.InsertPoint();
        p3.InsertPoint();

        Point? deletedPoint = p3.DeletePoint();
        p3.Update(new Point() { X = 121 });
        
         foreach (Point p in Point.GetAllPoints())
         {
             Console.WriteLine(p);
         }
         Point.GetAllPoints().ForEach(p => Console.WriteLine(p));
         Point.Points.ForEach(Console.WriteLine);
         p1.DeletePoint();
         Console.WriteLine(p1);
    }
}