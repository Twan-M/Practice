namespace FietsExample;

public abstract class ElektrischOnderdeel : IArtikelMetKostprijs
{
    public string Naam { get; set; }
    public float BasisPrijs { get; set; }

    protected ElektrischOnderdeel(string naam, float basisPrijs)
    {
        Naam = naam;
        BasisPrijs = basisPrijs;
    }

    public virtual float BerekenKostprijs()
    {
        return BasisPrijs;
    }
}