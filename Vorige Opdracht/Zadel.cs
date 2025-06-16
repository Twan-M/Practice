namespace FietsExample;

public class Zadel : BasisOnderdeel
{
    public string Materiaal { get; set; }

    public Zadel(string naam, float basisPrijs, string materiaal) : base(naam, basisPrijs)
    {
        Materiaal = materiaal;
    }
}