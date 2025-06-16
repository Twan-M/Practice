namespace FietsExample;

public class ElektrischeFiets : Fiets
{
    public int Actieradius { get; set; }

    public ElektrischeFiets(int nummer, string naam, float opslag, string merk, float basisPrijs, int actieradius) : base(nummer, naam, opslag, merk, basisPrijs)
    {
        Actieradius = actieradius;
    }

    public override float BerekenKostprijs()
    {
        return base.BerekenKostprijs();
    }
}