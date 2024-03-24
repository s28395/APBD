namespace Zad3.Models;

public class Plyny : Kontener
{
    public string NazwaProduktu;
    public static int counerSeryjny = 0;
    
    public Plyny(string nazwaProduktu, double MasaLadunku, double wysokosc, double WagaWlasna, double glebokosc) : base(MasaLadunku, wysokosc, WagaWlasna, glebokosc)
    {
        NazwaProduktu = nazwaProduktu;

    }
    public void Load(double weight)
    {
        try
        {
            if (NazwaProduktu.Equals("paliwo") && MasaLadunku + weight <= WagaWlasna / 2)
            {
                MasaLadunku += weight;
            }
            else if (NazwaProduktu.Equals("mleko") && MasaLadunku + weight <= (0.9 * WagaWlasna))
            {
                MasaLadunku += weight;
            }
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
        return "KON-L-" + ++counerSeryjny;
    }


    public override void Unload()
    {
        MasaLadunku = 0;
        base.Unload();
    }
}