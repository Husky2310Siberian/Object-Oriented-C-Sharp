namespace Copying.Model;

public class Student
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public Address? Address { get; set; }

    public Student() { }

    public Student(int id, string? firstName, string? lastName, Address? address)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Address = address;
    }

    public Student GetRef()
    {
        return this;
    }

    /// <summary>
    /// This method returns a reference to the same object.
    /// Calling this does not create a new copy,
    /// it just provides another reference to the same object in memory.
    /// </summary>
    /// <returns></returns>
    public Student GetShallowCopy()
    {
        return (Student)MemberwiseClone();
    }

    /// <summary>
    /// A new Student object is created.
    /// The primitive and string properties (Id, FirstName, LastName) are copied.
    /// The reference to Address is copied, not duplicated.
    /// Both the original and copied students share the same Address instance.
    /// </summary>
    /// <returns></returns>
    public Student GetDeepCopy()
    {
        Student student = (Student)MemberwiseClone();
        
        if(Address != null)
        {
            student.Address = new Address(Address.StreetName, Address.StreetNumber , Address.ZipCode );
        }
        else
        {
            student.Address = null;
        }
        return student;
    }
}