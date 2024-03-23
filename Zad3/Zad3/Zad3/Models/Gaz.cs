namespace Zad3.Models;

public class Gaz : Kontener, IHazardNotifier
{
    public Gaz(double MasaLadunku, double wysokosc, double WagaWlasna, double glebokosc, string numerSeryjny) : base(MasaLadunku, wysokosc, WagaWlasna, glebokosc, numerSeryjny)
    {
    }
    

    public void HazardNotifier(string text)
    {
        throw new NotImplementedException();
    }
}