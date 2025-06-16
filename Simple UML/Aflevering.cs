namespace OefenOpdracht;

public class Aflevering
{
    public String Title {get; set;}
    public int Runtime {get; set;}
    private Serie Serie { get; }

    public Aflevering(string title, int runtime, Serie serie)
    {
        Title = title;
        Runtime = runtime;
        Serie = serie;
    }
}