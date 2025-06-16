using FietsExample;
class Program
{
    static void Main(string[] args)
    {
        // Initialiseer Catalogus
        Catalogus.GetInstance();

        // Maak klant John Doe
        var john = new Klant(1, "John Doe", "john.doe@gmail.com");

        // Haal producten op uit catalogus
        var racefiets = Catalogus.GetInstance().Lookup(1); // John’s titanium racefiets
        var elektrischeFiets = Catalogus.GetInstance().Lookup(2); // Anne’s elektrische fiets
        var gps = Catalogus.GetInstance().Lookup(3); // GPS accessoire
        var fietstassen = Catalogus.GetInstance().Lookup(4); // Fietstassen accessoire

        // Maak bestelling aan
        var bestelling = new Bestelling(1001);

        // Voeg regels toe: 1 fiets + accessoire voor John, 1 fiets + accessoire voor Anne
        bestelling.Regels.Add(new Regel(1, racefiets));
        bestelling.Regels.Add(new Regel(2, elektrischeFiets));
        bestelling.Regels.Add(new Regel(3, gps));
        bestelling.Regels.Add(new Regel(4, fietstassen));

        // Bereken totaalprijs en toon deze
        float totaalPrijs = bestelling.BerekenTotaalPrijs();
        Console.WriteLine($"Totaalprijs bestelling: {totaalPrijs} EUR");

        // Stuur bevestiging naar John
        john.StuurBevestiging(bestelling);

        // Pauze zodat console niet direct sluit
        Console.ReadLine();
    }
}