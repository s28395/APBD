namespace Zad3;

public abstract class Kontener : IHazardNotifier
{
    public double MasaLadunku { get; set;  }
    public double Wysokosc { get; }
    public double WagaWlasna { get; }
    public double Glebokosc { get;  }
    public string NumerSeryjny { get; set; }

    protected Kontener(double MasaLadunku, double wysokosc, double WagaWlasna, double glebokosc)
    {
        this.MasaLadunku = MasaLadunku;
        Wysokosc = wysokosc;
        this.WagaWlasna = WagaWlasna;
        Glebokosc = glebokosc;
        NumerSeryjny = numerSeryjny();
    }
    
    public virtual string numerSeryjny()
    {
        return "";
    }
   

    public virtual void Unload()
    {
        
    }

    public bool WeightIsOk()
    {
        return MasaLadunku <= WagaWlasna;
    }

    public void HazardNotifier(string text)
    {
        Console.WriteLine($"Kontener is {NumerSeryjny} in hazard error");
    }
}