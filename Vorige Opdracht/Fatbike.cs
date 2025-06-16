namespace FietsExample;

public class Fatbike : Fiets
{
    public Fatbike(int nummer, string naam, float opslag, string merk, float basisPrijs) : base(nummer, naam, opslag, merk, basisPrijs)
    {
    }

    public override float BerekenKostprijs()
    {
        float kostprijs = base.BerekenKostprijs();
        // Vette wielen: 10% duurder
        kostprijs *= 1.10f;
        return kostprijs;
    }
}