namespace OefenOpdracht2;

public interface IBankRekening
{
    public String RekeningNummer { get; }
    public void Storten(int bedrag);
}