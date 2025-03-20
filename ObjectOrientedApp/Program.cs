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
       //                    3. some fields maybe are null , because we don want them
       Teacher anna = new Teacher() 
       {
           Id = 1,
           Firstname = "Anna"
           //Lastname = "Annadel",
       };
       Console.WriteLine(anna.Id +"."+ anna.Firstname);
       
       //Constructor
       Teacher andrew = new Teacher(1, "Andrew" , "Smith", SchoolType.BSc);
       
       Teacher teacher4 = new Teacher(201, "David" , "Jones" , SchoolType.BSc);
       Teacher teacher5 = new Teacher(202, "Jones" , "Jones" , SchoolType.MSc);
       Teacher teacher6 = new Teacher(202, "Jones" , "Jones" , SchoolType.MSc);
       andrew.Id = 1;
       andrew.Firstname = "Andrew";
       andrew.Lastname = "Andrew";
       andrew.SchoolType = SchoolType.BSc;
       Console.WriteLine(teacher4.Equals(teacher5));
       Console.WriteLine(teacher5.Equals(teacher6));
       Console.WriteLine(teacher6 + "--> " + SchoolType.BSc.ToString());
       
       
       Teacher teacher1 = new Teacher(101 , "John" , "Smith" , SchoolType.BSc); //same HashCode
       Teacher teacher2 = new Teacher(102 , "John2" , "Smith2" , SchoolType.BSc);
       Teacher teacher3 = new Teacher(101 , "John" , "Smith" , SchoolType.BSc); //same HashCode
       
       Console.WriteLine(teacher1.GetHashCode());
       Console.WriteLine(teacher2.GetHashCode());
       Console.WriteLine(teacher3.GetHashCode());
       
       Student john = new Student();
       //john.Id = 1;   // i cant have set id, because _id is readonly and does not give me set 
       john.Firstname = "John";
       john.Lastname = "Smith";
       
       
       Console.WriteLine(john.Id+ ". " +john.Firstname +" "+ john.Lastname);
    }
}
