namespace ObjectOrientedApp.Model;
/// <summary>
/// POCO class
/// </summary>
public class Teacher
{
    // auto-implemented properties with get and set
    public int Id { get; set; }
    public string? Firstname { get; set; }
    public string? Lastname { get; set; }

    // default constructor that allows, creating an instance without setting values.
    public Teacher() { }

    // parameterized constructor that sets initial values.
    public Teacher(int id, string? firstname, string? lastname)
    {
        Id = id;
        Firstname = firstname;
        Lastname = lastname;
    }

    public override string? ToString() => $"{Id} {Firstname} {Lastname}";

    //  Compares two Teacher objects for equality.
    public override bool Equals(object? obj)
    {
        return obj is Teacher teacher && Id == teacher.Id 
                                      && Firstname == teacher.Firstname
                                      && Lastname == teacher.Lastname;
    }

    // Generates a unique integer (hash code) for each Teacher object.
    // Each Teacher object gets a unique hash code.
    // If two Teacher objects have the same Id, Firstname, and Lastname, their hash codes will be the same.
    public override int GetHashCode()
    {
        // return Id.GetHashCode() ^ Firstname.GetHashCode() ^ Lastname.GetHashCode();
        return HashCode.Combine(Id, Firstname, Lastname);
    }
}