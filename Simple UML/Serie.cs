namespace OefenOpdracht;

public class Serie : Medium
{
    private List<Aflevering> afleveringen = new List<Aflevering>();

    public void VoegAfleveringToe(String titel,  int runtime)
    {
        afleveringen.Add(new Aflevering(titel, runtime, this));
    }
}