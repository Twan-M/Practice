namespace OefenOpdracht2;

public class FlexBetalen : BankrekeningBase, IBetaalRekening
{
    private int MaximaalKrediet { get; set; }

    public FlexBetalen(String rekeningNummer) : base(rekeningNummer)
    {
        MaximaalKrediet = 100;
    }

    public int GetMaximaalKrediet()
    {
        return MaximaalKrediet;
    }

    public void Opnemen(int bedrag)
    {
        if (Saldo - bedrag < 0 - MaximaalKrediet)
        {
            throw new ArgumentException("Onvoldoende Saldo");
        }
        Saldo -= bedrag;
    }

    public void Overmaken(int bedrag, string rekeningNummer)
    {
        //Niet juiste implementatie
        Opnemen(bedrag);
    }
}