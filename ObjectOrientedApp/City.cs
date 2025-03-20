namespace ObjectOrientedApp.Model;

public class City
{
    private int _id;
    private string _name;

    // These are public properties that provide read-only access, to the private fields.
    // No set method → This makes them immutable (their values cannot be changed after object creation).
    // instead of set --> i can use init, its the same
    public int Id { get { return _id; } init { _id = value; } }
    public string? Firstname { get { return _name; } init { _name = value; } }

    public City() { }

    public City(int id, string name)
    {
        _id = id;
        _name = name;
    }
}