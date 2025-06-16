namespace OefenOpdracht4;

public abstract class Fruit
{
    public String Kleur {get; private set;}
    public int KwaliteitsIndex {get; private set;}

    protected Fruit(string kleur, int kwaliteitsIndex)
    {
        Kleur = kleur;
        KwaliteitsIndex = kwaliteitsIndex;
    }
}