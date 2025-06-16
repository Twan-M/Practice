namespace FietsExample;

public class Racefiets : Fiets
{
    public float Gewicht { get; set; }

    public Racefiets(int nummer, string naam, float opslag, string merk, float basisPrijs, float gewicht) : base(nummer, naam, opslag, merk, basisPrijs)
    {
        Gewicht = gewicht;
    }

    public override float BerekenKostprijs()
    {
        float kostprijs = base.BerekenKostprijs();
        // Speciaal: titanium frame => 30% opslag
        if (Naam.ToLower().Contains("titanium"))
        {
            kostprijs *= 1.3f;
        }
        return kostprijs;
    }
}