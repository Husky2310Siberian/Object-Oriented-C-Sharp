namespace AbstractClassesApp.Model;

internal abstract class AbstractAnimal
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public double Age { get; set; }

    public AbstractAnimal() { }

    protected AbstractAnimal(int id, string? name, double age)
    {
        Id = id;
        Name = name;
        Age = age;
    }

    public abstract override string ToString();
    
    public abstract void Speak();
    
    public virtual void Eat()
    {
        Console.WriteLine(Name + " is eating");
    }
}