using ObjectOrientedApp.Model;

namespace ObjectOrientedApp;

class Program
{
    static void Main(string[] args)
    {
       Teacher alice = new Teacher();
       Teacher bob = new();
       var charlie = new Teacher();

       // Object initializer :
       //                    1. using default Constructor!!!
       //                    2. needs setter or init
       //                    3. some fields maybe are null
       Teacher anna = new Teacher() 
       {
           Id = 1,
           Firstname = "Anna",
           Lastname = "Annadel",
       };
       
       Teacher andrew = new Teacher(1, "Andrew" , "Smith");
       
       Teacher teacher4 = new Teacher(201, "David" , "Jones");
       Teacher teacher5 = new Teacher(202, "Jones" , "Jones");
       Teacher teacher6 = new Teacher(202, "Jones" , "Jones");
       
       Console.WriteLine(teacher4.Equals(teacher5));
       Console.WriteLine(teacher5.Equals(teacher6));
       
       
       Teacher teacher1 = new Teacher(101 , "John" , "Smith"); //same HashCode
       Teacher teacher2 = new Teacher(102 , "John2" , "Smith2");
       Teacher teacher3 = new Teacher(101 , "John" , "Smith"); //same HashCode
       
       Console.WriteLine(teacher1.GetHashCode());
       Console.WriteLine(teacher2.GetHashCode());
       Console.WriteLine(teacher3.GetHashCode());
       
       
       
       
       
    }
    
    
}
