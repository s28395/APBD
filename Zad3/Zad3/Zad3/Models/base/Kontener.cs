namespace Zad3;

public abstract class Kontener
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

    public void Unload()
    {
        MasaLadunku = 0;
    }
}

public class OverfillException : Exception
{
    public OverfillException(string? message) : base(message)
    {
    }
}