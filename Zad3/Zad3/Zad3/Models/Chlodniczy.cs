namespace Zad3.Models;

public class Chlodniczy : Kontener
{
    public string Rodzaj;
    public double temperatura;

    public Chlodniczy(string Rodzaj, double temperatura, double MasaLadunku, double wysokosc, double WagaWlasna,
        double glebokosc, string numerSeryjny) : base(MasaLadunku, wysokosc, WagaWlasna, glebokosc, numerSeryjny)
    {
        if (this.Rodzaj.Equals("bananas") && this.temperatura > 13.3) throw new OverfillException("Error");
        if (this.Rodzaj.Equals("chocolate") && this.temperatura > 18) throw new OverfillException("Error");
        if (this.Rodzaj.Equals("fish") && this.temperatura > 2) throw new OverfillException("Error");
        if (this.Rodzaj.Equals("meat") && this.temperatura > -15) throw new OverfillException("Error");
        if (this.Rodzaj.Equals("ice cream") && this.temperatura > -18) throw new OverfillException("Error");
        if (this.Rodzaj.Equals("frozen pizza") && this.temperatura > -30) throw new OverfillException("Error");
        if (this.Rodzaj.Equals("cheese") && this.temperatura > 7.2) throw new OverfillException("Error");
        if (this.Rodzaj.Equals("sausages") && this.temperatura > 5) throw new OverfillException("Error");
        if (this.Rodzaj.Equals("butter") && this.temperatura > 20.5) throw new OverfillException("Error");
        if (this.Rodzaj.Equals("eggs") && this.temperatura > 19) throw new OverfillException("Error");

        this.Rodzaj = Rodzaj;
        this.temperatura = temperatura;

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
        MasaLadunku = 0;
        base.Unload();
    }
}