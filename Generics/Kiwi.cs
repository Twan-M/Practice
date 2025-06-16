namespace OefenOpdracht4;

public abstract class Kiwi : Fruit
{
    public Kiwi(string kleur, int kwaliteitsIndex) : base(kleur, kwaliteitsIndex)
    {
    }
}

public class Jenny : Kiwi
{
    public Jenny(int kwaliteitsIndex) : base("Groen", kwaliteitsIndex)
    {
    }
}

public class ZespriGold : Kiwi
{
    public ZespriGold(int kwaliteitsIndex) : base("Geel", kwaliteitsIndex)
    {
    }
}