namespace OefenOpdracht3;

public class Hamster : Animal
{
    public Hamster(string name) : base(name)
    {
    }

    public override String GetKind()
    {
       return "Hamster";
    }

    public override void MakeSomeNoise()
    {
        Console.WriteLine("Hamster Noises");
    }
}