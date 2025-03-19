namespace ObjectOrientedApp.Model;

public class Student
{
    private int _id;
    private string? _firstname;
    private string? _lastname;
    //private string _lastname = null!; (for entities, when sth is necessary, so it can not be null)

    //properties
    public int Id { get { return _id; } set {_id = value; } }
    public string? Firstname { get { return _firstname; } set { _firstname = value; } }
    public string? Lastname { get { return _lastname; } set { _lastname = value; } }

     
    public Student()
    {
        
    }

    public Student(int id, string? firstname, string? lastname)
    {
        _id = id;
        _firstname = firstname;
        _lastname = lastname;
    }
}