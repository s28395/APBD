namespace Zad3;

public abstract class Kontener
{
    private double MasaAll { get; }
    private double Wysokosc { get; }
    private double MasaKontenera { get;  }
    private double Glebokosc { get;  }
    private string NumerSeryjny { get; set; }

    protected Kontener(double masaAll, double wysokosc, double masaKontenera, double glebokosc, string numerSeryjny)
    {
        MasaAll = masaAll;
        Wysokosc = wysokosc;
        MasaKontenera = masaKontenera;
        Glebokosc = glebokosc;
        NumerSeryjny = numerSeryjny;
    }
}