namespace AnimalSaysHi;

class Program
{
    static void Main(string[] args)
    {
        Pig myPig = new Pig(); // create a new object
        myPig.AnimalSaysHi();
        
        DemoClass demoClassObj = new DemoClass();
        demoClassObj.FirstMethod();
        demoClassObj.SecondMethod();
    }
}