/// <summary>
/// Represents a point in a one-dimensional space.
/// </summary>
public class Point
{
    /// <summary>
    /// Gets or sets the X-coordinate of the point.
    /// </summary>
    public int X { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Point"/> class with default values.
    /// </summary>
    public Point() { }

    /// <summary>
    /// Initializes a new instance of the <see cref="Point"/> class with a specified X-coordinate.
    /// </summary>
    /// <param name="x">The X-coordinate of the point.</param>
    public Point(int x)
    {
        X = x;
    }

    /// <summary>
    /// Returns a string representation of the point.
    /// </summary>
    /// <returns>A string representing the point.</returns>
    public override string? ToString()
    {
        return $"X: {X}";
    }

    /// <summary>
    /// Returns a new instance of the <see cref="Point"/> class with default values.
    /// </summary>
    /// <returns>A new <see cref="Point"/> instance.</returns>
    public static Point GetOnePoint()
    {
        return new Point();
    }

    /// <summary>
    /// Moves the point by adding 10 to the X-coordinate.
    /// </summary>
    public virtual void Move10()
    {
        X += 10;
    }
}