namespace Zad3.Models;

public class Gaz : Kontener
{
    public Gaz(double MasaLadunku, double wysokosc, double WagaWlasna, double glebokosc, string numerSeryjny) : base(MasaLadunku, wysokosc, WagaWlasna, glebokosc, numerSeryjny)
    {
    }

    public override void Load(double weight)
    {
        if (MasaLadunku + weight <= WagaWlasna) MasaLadunku += weight;
        else
        {
            base.Load(weight);
        }
    }

    public override void Unload()
    {
        MasaLadunku = 0.05 * MasaLadunku;
        base.Unload();
    }
    
    
}