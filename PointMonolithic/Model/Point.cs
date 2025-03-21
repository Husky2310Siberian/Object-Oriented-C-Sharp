namespace PointMonolithic.Model;

public class Point : IEquatable<Point>, IComparable<Point>
{
    public int X { get; set; }
    private static readonly List<Point?> _points = new List<Point>();

    public static List<Point?> Points { get { return new List<Point?>(_points); } }

    public Point() { }

    public Point(int x)
    {
        X = x;
    }

    /// <summary>
    /// This method implements the IEquatable<Point> interface.
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    public bool Equals(Point? other)
    {
        if (other is null) return false;
        return CompareTo(other) == 0;
    }
    
    /// <summary>
    /// Implements IComparable<Point>, which is used for sorting.
    /// this.X refers to the X property of the current instance of the Point class.
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    public int CompareTo(Point? other)
    {
        return this.X - other!.X;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object? obj)
    {
        return (obj is Point other)  && Equals(other);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
        return HashCode.Combine(X);
    }

    /// <summary>
    ///
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return $"(X:{{{X}}})";
    }

    public static bool operator >(Point? p1, Point? p2)
    {
        if(p1 is null || p2 is null) return false;
        return p1.X > p2.X;
    }
    
    public static bool operator <(Point? p1, Point? p2)
    {
        if(p1 is null || p2 is null) return false;
        return p1.X < p2.X;
    }
    
    public static bool operator >=(Point? p1, Point? p2)
    {
        if(p1 is null || p2 is null) return false;
        return p1.X >= p2.X;
    }
    
    public static bool operator <=(Point? p1, Point? p2)
    {
        if(p1 is null || p2 is null) return false;
        return p1.X <= p2.X;
    }
    
    public static bool operator ==(Point? p1, Point? p2)
    {
        if(p1 is null || p2 is null) return false;
        return p1.X == p2.X;
    }
    
    public static bool operator !=(Point? p1, Point? p2)
    {
        if(p1 is null || p2 is null) return false;
        return p1.X != p2.X;
    }
    /*
     * CRUD API
     */
    public void Insert()
    {
        _points.Add(this);
    }

    public bool Update(Point? point)
    {
        int positionToUpdate = GetPointPosition();
        if(positionToUpdate == -1) return false;
        _points[positionToUpdate] = point!;
        return true;
    }

    public Point? Delete()
    {
        int positionToDelete = GetPointPosition();
        if(positionToDelete == -1) return null;
        Point? pointToReturn = _points[positionToDelete];
        _points.RemoveAt(positionToDelete);
        return pointToReturn;
    }

    public Point? GetOnePoint()
    {
        return _points.Contains(this) ? _points[GetPointPosition()] : null;
    }

    private int GetPointPosition()
    {
        return _points.IndexOf(this);
    }
    
    /*
     * Service API
     */
    public void InsertPoint()
    {
        Insert();
    }

    public Point? UpdatePoint(Point? point)
    {
        if (Update(point)) return point;
        return null;
    }

    public Point? DeletePoint()
    {
        return Delete();
    }

    public Point? GetPoint()
    {
        return GetOnePoint();
    }

    public static List<Point?> GetAllPoints()
    {
        return new List<Point?>(_points);
    }
}