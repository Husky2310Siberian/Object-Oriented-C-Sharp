using StudentApp.Model;

namespace StudentApp.Service;

public class StudentService : IStudentService
{
    private readonly Dictionary<int, Student> _students = new();
    
    public void InsertStudent(Student student)
    {
        if (_students.ContainsKey(student.Id))
            throw new InvalidOperationException("Student ID already exists");
        
        _students.Add(student.Id, student);
    }

    public void DeleteStudent(int id)
    {
        if(!_students.ContainsKey(id))
            throw new InvalidOperationException("Student ID does not exist");
    }

    public void UpdateStudent(Student student)
    {
        if(!_students.ContainsKey(student.Id))
            throw new KeyNotFoundException("Student ID does not exist");
        _students[student.Id] = student;
    }

    public Student GetStudentById(int id)
    {
       return _students.TryGetValue(id, out var student) ? student : null;
    }

    public IReadOnlyCollection<Student> GetAllStudents()
    {
        return _students.Values;
    }
}