using StudentApp.Model;

namespace StudentApp.Service;
/// <summary>
/// Defines CRUD operations for StudentService.
/// </summary>
public interface IStudentService
{
    void InsertStudent(Student student);
    void DeleteStudent(int id);
    void UpdateStudent(Student student);
    Student GetStudentById(int id);
    IReadOnlyCollection<Student> GetAllStudents();
    
}