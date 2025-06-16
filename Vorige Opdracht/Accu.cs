namespace FietsExample;

public class Accu : ElektrischOnderdeel
{
    public int WattUur { get; set; }

    public Accu(string naam, float basisPrijs, int wattUur) : base(naam, basisPrijs)
    {
        WattUur = wattUur;
    }

    public override float BerekenKostprijs()
    {
        float opslag = 0;
        if (WattUur > 400)
        {
            opslag = 2 * (WattUur - 400);
        }
        return BasisPrijs + opslag;
    }
}