namespace OefenOpdracht2;

public interface IBetaalRekening
{
    protected int GetMaximaalKrediet();

    public void Opnemen(int bedrag);

    public void Overmaken(int bedrag, String rekeningNummer);
}