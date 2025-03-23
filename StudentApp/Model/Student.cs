using System.Collections;

namespace StudentApp.Model;
/// <summary>
/// Represents the main entity in the system, containing full student details.
/// </summary>
public class Student : IEquatable<Student> , IComparable<Student> 
{
   //Inner Layer
   public int Id { get; set; }
   public string? Lastname { get; set; }
   public int Grade { get; set; }
   public int Age { get; set; }
   
   private static readonly SortedDictionary<int,Student> _students = new ();
   
   public static SortedDictionary<int,Student> Students => _students;

   public Student() { }

   public Student(int id, string? lastname, int grade, int age)
   {
      Id = id;
      Lastname = lastname;
      Grade = grade;
      Age = age;
   }

   public override bool Equals(object? obj) => obj is Student other && Equals(other);
   
   public bool Equals(Student? other) => other is not null && Id == other.Id;
   
   public override int GetHashCode() => HashCode.Combine(Id);

   public override string ToString() => $"{Id}: {Lastname} --> {Grade} ,  {Age}";

   public int CompareTo(Student? other)
   {
      if (other is null) return 1;
      int gradeComparison = Grade.CompareTo(other.Grade);
      return gradeComparison != 0 ? gradeComparison : string.Compare(Lastname, other.Lastname, StringComparison.Ordinal);
   }

   public void Insert()
   {
      if (!_students.ContainsKey(Id))
      {
         _students.Add(Id, new Student());
      }
      else
      {
         throw new InvalidOperationException("Student ID already exists");
      }
   }

   public void Update()
   {
      if (_students.ContainsKey(Id))
         _students[Id] = this;
      else
      {
         throw new KeyNotFoundException("Student ID does not exist");
      }
   }

   public void Delete()
   {
      if (!_students.ContainsKey(Id))
      {
         throw new KeyNotFoundException("Student ID does not exist");
      }
      else
      {
         _students.Remove(Id);
      }
   }
   
   public static IReadOnlyDictionary<int, Student> GetAllStudents => new Dictionary<int,Student>(_students);
}