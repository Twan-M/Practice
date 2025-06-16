namespace FietsExample;
public abstract class Fiets : Product
{
    public string Merk { get; set; }
    public float BasisPrijs { get; set; }

    public List<IArtikelMetKostprijs> Onderdelen { get; set; } = new List<IArtikelMetKostprijs>();

    protected Fiets(int nummer, string naam, float opslag, string merk, float basisPrijs) : base(nummer, naam, opslag)
    {
        Merk = merk;
        BasisPrijs = basisPrijs;
    }

    public override float BerekenKostprijs()
    {
        float totaal = BasisPrijs;
        foreach (var onderdeel in Onderdelen)
        {
            totaal += onderdeel.BerekenKostprijs();
        }
        return totaal;
    }
}
