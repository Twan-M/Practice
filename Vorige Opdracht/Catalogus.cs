namespace FietsExample;

public class Catalogus
{
    private static Catalogus? _instance;

    public static Catalogus GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Catalogus();
            _instance.Initialiseer();
        }
        return _instance;
    }

    private List<Product> producten = new List<Product>();

    public void Initialiseer()
{
    // === Frames ===
    var aluminiumFrame = new Frame("Aluminium Frame", 0, "Recht", "Aluminium");
    var titaniumFrame = new Frame("Titanium Frame", 0, "Gebogen", "Aluminium");

    // === Zadels ===
    var sellaRoyalZadel = new Zadel("Sella Royal", 75f, "Leer");
    var brooksZadel = new Zadel("Brooks", 150f, "Leer");

    // === Wielen ===
    var voorwiel = new Wiel("Voorwiel", 89f);
    var achterwiel = new Wiel("achterwiel", 99f);

    // === Elektrisch ===
    var motor = new Motor("Motor", 600f, 250);
    var accu500 = new Accu("Accu", 350f, 500);

    // === Accessoires ===
    var gps = new Accessoire(1, "GPS", 0f, 325);
    var fietstassen = new Accessoire(1, "Fietstassen", 0f, 90);

    // Racefiets heren aluminium
    var raceFiets = new Racefiets(1, "Heren Racefiets Titanium", 0f, "Heren", 800f, 9);
    raceFiets.Onderdelen = new List<IArtikelMetKostprijs>
    {
        titaniumFrame,
        sellaRoyalZadel,
        voorwiel,
        achterwiel
    };
    
    // Elektrische Fiets Danes aluminium
    var elektrischeFiets = new ElektrischeFiets(2, "Dames Elektrische Fiets Aluminium", 0f, "Dames", 1250f, 130);
    elektrischeFiets.Onderdelen = new List<IArtikelMetKostprijs>
    {
        aluminiumFrame,
        brooksZadel,
        motor,
        accu500,
        voorwiel,
        achterwiel
    };

    // === Accessoires los ===
    gps.Nummer = 3;
    fietstassen.Nummer = 4;

    // === Voeg alles toe aan catalogus ===
    producten.Add(raceFiets);
    producten.Add(elektrischeFiets);
    producten.Add(gps);
    producten.Add(fietstassen);
}

    public Product Lookup(int nummer)
    {
        return producten.Find(x => x.Nummer == nummer);
    }

    public void VoegProductToe(Product product)
    {
        producten.Add(product);
    }
}