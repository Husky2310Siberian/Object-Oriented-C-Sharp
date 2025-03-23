using StudentApp.Model;
using StudentApp.Service;

namespace StudentApp;

class Program
{
    static void Main(string[] args)
    {
        IStudentService studentService = new StudentService();
        //generate two students
        var student1 = new Student(1, "Doe", 9.5 , 19);
        var student2 = new Student(2, "Wonderland", 8.8 , 18);
        //insert two students
        studentService.InsertStudent(student1);
        studentService.InsertStudent(student2);
        Console.WriteLine("======================");
        // display students list
        Console.WriteLine("Get All Students");
        foreach (var Student in studentService.GetAllStudents())
        {
            Console.WriteLine(Student);
        }
        Console.WriteLine("======================");
        // update students
        student1.Lastname = "Doe junior";
        student2.Lastname = "Wonderland junior";
        studentService.UpdateStudent(student1);
        studentService.UpdateStudent(student2);
        Console.WriteLine("Get All Students after Update");
        foreach (var Student in studentService.GetAllStudents())
        {
            Console.WriteLine(Student);
        }
        
        Console.WriteLine("======================");
        // get total students
        var allCountStudents = studentService.GetAllStudents();
        Console.WriteLine($"Total students : {allCountStudents.Count}");
        
        Console.WriteLine("======================");
        // get students by id
        var studentById = studentService.GetStudentById(2);
        Console.WriteLine($"Student by id  : {studentById}");
        
        Console.WriteLine("======================");
       // Delete a Student
       studentService.DeleteStudent(2);
       Console.WriteLine("Students after Delete");
       foreach (var student in studentService.GetAllStudents())
       {
           Console.WriteLine(student);
       }

    }
}