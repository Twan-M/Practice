namespace OefenOpdracht3;

public class Dog : Animal, IHasTail
{
    public Dog(string name) : base(name)
    {
    }

    public override void MakeSomeNoise()
    {
        Console.WriteLine("Dog noises");
    }

    public override String GetKind()
    {
        return "Dog";
    }

    public void Wag()
    {
        Console.WriteLine($"{Name} Wags");
    }
}