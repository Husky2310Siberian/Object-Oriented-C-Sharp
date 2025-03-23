namespace StudentApp.Model;
/// <summary>
/// 
/// </summary>
public class Student
{
    public long Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Address { get; set; }

    private static readonly SortedDictionary<long, string> ListStudents = new SortedDictionary<long, string>()
    {
        { 1, "Alice" },
        { 2, "Bob" },
        { 3, "Charlie" },
        { 4, "Danny" },
    };

    public static SortedDictionary<long,string> Students { get { return new SortedDictionary<long, string>(ListStudents); } }
    
}