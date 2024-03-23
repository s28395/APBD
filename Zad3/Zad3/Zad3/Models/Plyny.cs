namespace Zad3.Models;

public class Plyny : Kontener, IHazardNotifier
{
    //ladunek niebiezpieczny - paliwo
    // biezpieczny - mleko

    public string NazwaProduktu;
    
    public Plyny(string nazwaProduktu, double MasaLadunku, double wysokosc, double WagaWlasna, double glebokosc, string numerSeryjny) : base(MasaLadunku, wysokosc, WagaWlasna, glebokosc, numerSeryjny)
    {
        this.NazwaProduktu = nazwaProduktu;
    }
    public override void Load(double weight)
    {
        if (NazwaProduktu.Equals("paliwo") && MasaLadunku + weight <= WagaWlasna/2) MasaLadunku += weight;
        else if (NazwaProduktu.Equals("mleko") && MasaLadunku + weight <= (0.9 * WagaWlasna) )MasaLadunku += weight;
        else
        {
            base.Load(weight);
        }
    }


    public void HazardNotifier(string text)
    {
        Console.WriteLine($"Kontener is {NumerSeryjny} in hazard error");
    }
}