namespace OefenOpdracht2;

public abstract class BankrekeningBase : IBankRekening
{
    protected int Saldo { get; set; }
    protected BankrekeningBase(string rekeningNummer)
    {
        RekeningNummer = rekeningNummer;
        Saldo = 0;
    }
    
    public string RekeningNummer { get; }

    public void Storten(int bedrag)
    {
        Saldo += bedrag;
    }
}