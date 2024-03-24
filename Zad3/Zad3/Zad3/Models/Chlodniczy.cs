namespace Zad3.Models;

public class Chlodniczy : Kontener
{
    public string Rodzaj;
    public double Temperatura;
    public static int counerSeryjny = 0;

    public Chlodniczy(string Rodzaj, double temperatura, double MasaLadunku, double wysokosc, double WagaWlasna,
        double glebokosc) : base(MasaLadunku, wysokosc, WagaWlasna, glebokosc)
    {
        try
        {
            this.Rodzaj = Rodzaj;
            this.Temperatura = temperatura;
            if (Verify() == false) throw new OverfillException($"Nie mozemy uzywac kontener {this.NumerSeryjny}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    
    public override string numerSeryjny()
    {
        return "KON-C-" + ++counerSeryjny;
    }

    public bool Verify()
    {
        if ((Rodzaj.Equals("bananas") && Temperatura <= 13.3) ||
            (Rodzaj.Equals("chocolate") && Temperatura <= 18) || (Rodzaj.Equals("fish") && Temperatura <= 2) ||
            (Rodzaj.Equals("meat") && Temperatura <= -15) || (Rodzaj.Equals("ice cream") && Temperatura <= -18) ||
            (Rodzaj.Equals("frozen pizza") && Temperatura <= -30) ||
            (Rodzaj.Equals("cheese") && Temperatura <= 7.2) || (Rodzaj.Equals("sausages") && Temperatura <= 5) ||
            (Rodzaj.Equals("butter") && Temperatura <= 20.5) ||
            (Rodzaj.Equals("eggs") && Temperatura <= 19))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Load(double weight)
    {
        try
        {
            if (Verify() == false) throw new OverfillException("Nie mozemy uzywac");
            if (MasaLadunku + weight <= WagaWlasna) MasaLadunku += weight;
            else
            {
                throw new OverfillException("Przekroczyl maksymalna wage");
            }
        }
        catch (OverfillException e)
        {
            Console.WriteLine(e.Message);
        }
    }
    
    public override void Unload()
    {
        MasaLadunku = 0;
        base.Unload();
    }
}