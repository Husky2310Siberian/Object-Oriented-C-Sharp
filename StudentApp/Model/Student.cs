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
   public double Grade { get; set; }
   public int Age { get; set; }
   
   private static readonly SortedDictionary<int,Student> _students = new ();
   
   public static SortedDictionary<int,Student> Students => _students;

   public Student() { }

   public Student(int id, string? lastname, double grade, int age)
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

   /*
    * CRUD
    */
   /// <summary>
   /// Inserts the student if the ID is unique.
   /// </summary>
   /// <exception cref="InvalidOperationException"></exception>
   public void InsertStudent()
   {
      if (!_students.ContainsKey(Id))
      {
         _students.Add(Id, this);
      }
      else
      {
         throw new InvalidOperationException("Student ID already exists");
      }
   }
   /// <summary>
   /// Updates student details if the StudentId exists.
   /// </summary>
   /// <exception cref="KeyNotFoundException"></exception>
   public void UpdateStudent()
   {
      if (_students.ContainsKey(Id))
         _students[Id] = this;
      else
      {
         throw new KeyNotFoundException("Student ID does not exist");
      }
   }
   /// <summary>
   ///  Removes the student if the ID exists.
   /// </summary>
   /// <exception cref="KeyNotFoundException"></exception>
   public void DeleteStudent()
   {
      if (!_students.ContainsKey(Id))
      {
         throw new KeyNotFoundException("Student ID does not exist");
      }
   }
   /// <summary>
   /// Returns a copy of _students to prevent modifications.
   /// </summary>
   public static IReadOnlyDictionary<int, Student> GetAllStudents() 
   {
      return new Dictionary<int,Student>(_students);
   }
   
   /*
    * Service
    */
   // public void Insert()
   // {
   //    InsertStudent();
   // }
   //
   // public Student? Update(Student? student)
   // {
   //    if (student is null) return null;
   //    UpdateStudent();
   //    return student;
   // }
   //
   // public void Delete()
   // {
   //    DeleteStudent();
   // }
   //
   // public void GetAllStudentsDetails()
   // {
   //    GetAllStudents();
   // }
}