namespace FietsExample;

public class Klant
{
    public int Nummer { get; set; }
    public string Naam { get; set; }
    public string Email { get; set; }

    public Klant(int nummer, string naam, string email)
    {
        Nummer = nummer;
        Naam = naam;
        Email = email;
    }

    public void StuurBevestiging(Bestelling bestelling)
    {
        Console.WriteLine($"Email naar {Email}: Uw bestelling kost {bestelling.BerekenTotaalPrijs()} EUR.");
    }
}