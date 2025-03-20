namespace PointApp.Model;

/// <summary>
/// Represents a point in a two-dimensional space.
/// </summary>
public class Point2D : Point
{
    /// <summary>
    /// Gets or sets the Y-coordinate of the point.
    /// </summary>
    public int Y { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Point2D"/> class with default values.
    /// </summary>
    public Point2D() : base()
    {
        Y = 0;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Point2D"/> class with specified X and Y coordinates.
    /// </summary>
    /// <param name="x">The X-coordinate of the point.</param>
    /// <param name="y">The Y-coordinate of the point.</param>
    public Point2D(int x, int y) : base(x)
    {
        Y = y;
    }

    /// <summary>
    /// Returns a string representation of the point.
    /// </summary>
    /// <returns>A string representing the point.</returns>
    public override string? ToString()
    {
        return base.ToString() + $" Y: {Y}";
    }

    /// <summary>
    /// Moves the point by adding 10 to both X and Y coordinates.
    /// </summary>
    public override void Move10()
    {
        base.Move10();
        Y += 10;
    }
}