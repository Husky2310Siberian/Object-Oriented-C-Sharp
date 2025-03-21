namespace AbstractClassesApp.Model;

internal class Cat : AbstractAnimal
{
    public override void Speak()
    {
        Console.WriteLine("Meow!");
    }

    public override void Eat()
    {
        Console.WriteLine(Name + " kitten is eating!");
    }

    public override string ToString()
    {
        return "Id" + Id + ", Name" + Name + ", Age" + Age;
    }
}