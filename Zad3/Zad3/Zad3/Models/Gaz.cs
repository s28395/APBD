namespace Zad3.Models;

public class Gaz : Kontener
{
    public static int counerSeryjny = 0;
    public Gaz(double MasaLadunku, double wysokosc, double WagaWlasna, double glebokosc) : base(MasaLadunku, wysokosc, WagaWlasna, glebokosc)
    {
    }

    public void Load(double weight)
    {
        try
        { 
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
    
    public override string numerSeryjny()
    {
        return "KON-G-" + ++counerSeryjny;
    }
    

    public override void Unload()
    {
        MasaLadunku = 0.05 * MasaLadunku;
        base.Unload();
    }
    
    
}