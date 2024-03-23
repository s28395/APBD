namespace Zad3;

public abstract class Kontener : IHazardNotifier
{
    public double MasaLadunku { get; set;  }
    public double Wysokosc { get; }
    public double WagaWlasna { get; }
    public double Glebokosc { get;  }
    public string NumerSeryjny { get; set; }

    protected Kontener(double MasaLadunku, double wysokosc, double WagaWlasna, double glebokosc, string numerSeryjny)
    {
        this.MasaLadunku = MasaLadunku;
        Wysokosc = wysokosc;
        this.WagaWlasna = WagaWlasna;
        Glebokosc = glebokosc;
        NumerSeryjny = numerSeryjny;
    }

    public virtual void Load(double weight)
    {
        throw new OverfillException("Przekroczyl maksymalna wage");
    }

    public virtual void Unload()
    {
        
    }

    public void HazardNotifier(string text)
    {
        Console.WriteLine($"Kontener is {NumerSeryjny} in hazard error");
    }
}

public class OverfillException : Exception
{
    public OverfillException(string? message) : base(message)
    {
    }
}