namespace OefenOpdracht4;

public abstract class Appel : Fruit
{
    public Appel(string kleur, int kwaliteitsIndex) : base(kleur, kwaliteitsIndex)
    {
    }
}

public class JonaGold : Appel
{
    public JonaGold(int kwaliteitsIndex) : base("Rood/Groen", kwaliteitsIndex)
    {
    }
}

public class PinkLady : Appel
{
    public PinkLady(int kwaliteitsIndex) : base("Roze", kwaliteitsIndex)
    {
    }
}