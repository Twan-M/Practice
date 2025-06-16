namespace FietsExample;

public abstract class BasisOnderdeel : IArtikelMetKostprijs
{
    public string Naam { get; set; }
    public float BasisPrijs { get; set; }

    protected BasisOnderdeel(string naam, float basisPrijs)
    {
        Naam = naam;
        BasisPrijs = basisPrijs;
    }

    public virtual float BerekenKostprijs()
    {
        return BasisPrijs;
    }
}