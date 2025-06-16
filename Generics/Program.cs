using OefenOpdracht4;

    var gemengdeKrat = new Krat<Fruit>();
    gemengdeKrat.AddFruit(new ZespriGold(6));
    gemengdeKrat.AddFruit(new JonaGold(7));
    
    Console.WriteLine(gemengdeKrat.AantalFruits());
    
    var kiwiKrat = new Krat<Kiwi>();
    kiwiKrat.AddFruit(new ZespriGold(6));
    kiwiKrat.AddFruit(new Jenny(7));