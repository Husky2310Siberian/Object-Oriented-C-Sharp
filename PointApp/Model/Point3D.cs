namespace PointApp.Model;

/// <summary>
/// Represents a point in a three-dimensional space.
/// </summary>
public class Point3D : Point2D
{
    /// <summary>
    /// Gets or sets the Z-coordinate of the point.
    /// </summary>
    public int Z { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Point3D"/> class with default values.
    /// </summary>
    public Point3D() { }

    /// <summary>
    /// Initializes a new instance of the <see cref="Point3D"/> class with specified X, Y, and Z coordinates.
    /// </summary>
    /// <param name="x">The X-coordinate of the point.</param>
    /// <param name="y">The Y-coordinate of the point.</param>
    /// <param name="z">The Z-coordinate of the point.</param>
    public Point3D(int x, int y, int z) : base(x, y)
    {
        Z = z;
    }

    /// <summary>
    /// Returns a string representation of the point.
    /// </summary>
    /// <returns>A string representing the point.</returns>
    public override string ToString()
    {
        return base.ToString() + " " + $"Z: {Z}";
    }

    /// <summary>
    /// Moves the point by adding 10 to the X, Y, and Z coordinates.
    /// </summary>
    public override void Move10()
    {
        base.Move10();
        Z += 10;
    }
}