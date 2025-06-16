namespace OefenOpdracht3;

public abstract class Animal
{
    public String Name { get; private set; }

    protected Animal(string name)
    {
        Name = name;
    }

    //Dit is een extra function die ALLE dieren hetzelfde doen. 
    public void Eat()
    {
        Console.WriteLine("Eating...");
    }

    public abstract void MakeSomeNoise();

    public abstract String GetKind();
}