using OefenOpdracht3;

    var animals = new List<Animal>();
    animals.Add(new Dog("Dogt"));
    animals.Add(new Hamster("Hamstert"));

    foreach (var animal in animals)
    {
        Console.WriteLine($"{animal.Name} is a {animal.GetKind()}");
        animal.MakeSomeNoise();
        
        //Op het moment dat Animal imlemenatie is van IHasTail dan laten waggen. (Casten / Polymorfisme)
        if (animal is IHasTail animalWithTail)
        {
            animalWithTail.Wag();
        }
    }