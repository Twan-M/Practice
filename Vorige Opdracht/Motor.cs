﻿namespace FietsExample;

public class Motor : ElektrischOnderdeel
{
    public int Vermogen { get; set; }

    public Motor(string naam, float basisPrijs, int vermogen) : base(naam, basisPrijs)
    {
        Vermogen = vermogen;
    }
}