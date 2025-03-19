namespace ObjectOrientedApp.Model;
/// <summary>
/// POCO class - Plain old CLR Object
/// </summary>
public sealed class ImmutableTeacher   //sealed --> meaning strict immutability
{
    public int Id { get; init; }
    public string? Firstname { get; init; }
    public string? Lastname { get; init; }

    public ImmutableTeacher() { }

    public ImmutableTeacher(int id, string? firstname, string? lastname)
    {
        Id = id;
        Firstname = firstname;
        Lastname = lastname;
    }
}