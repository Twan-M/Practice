namespace FietsExample;

public class Frame : BasisOnderdeel
{
    public string Vorm { get; set; }
    public string Materiaal { get; set; }

    public Frame(string naam, float basisPrijs, string vorm, string materiaal) : base(naam, basisPrijs)
    {
        Vorm = vorm;
        Materiaal = materiaal;
    }
}