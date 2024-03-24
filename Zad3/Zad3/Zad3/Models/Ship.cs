using System.ComponentModel;
using System.Text;

namespace Zad3.Models;

public class Ship
{
    private List<Kontener> Container { get; } = new List<Kontener>();
    private string nameShip;
    private double MaxPredkosc;
    private int MaxKonteners;
    private double MaxWeight;
    private double MasaTeraz;
    private int counter = 0;

    public Ship(string nameShip, double maxPredkosc, int maxKonteners, double maxWeight)
    {
        this.nameShip = nameShip;
        MaxPredkosc = maxPredkosc;
        MaxKonteners = maxKonteners;
        MaxWeight = maxWeight;
        MasaTeraz = 0;
    }

    public void LoadShip(Kontener kontener)
    {
        try
        {
            if (kontener.WeightIsOk())
            {
                if (kontener is Chlodniczy chlodniczy)
                {
                    if (chlodniczy.Verify() && ++counter <= MaxKonteners &&
                        MasaTeraz + kontener.MasaLadunku <= MaxWeight)
                    {
                        Container.Add(kontener);
                        MasaTeraz += kontener.MasaLadunku;
                    }
                    else
                    {
                        if (counter <= MaxKonteners) --counter;
                        throw new OverfillException("Nie mozemy dodac lub za duzo kontenerow");
                    }
                }
                else if (++counter <= MaxKonteners && MasaTeraz + kontener.MasaLadunku <= MaxWeight)
                {
                    Container.Add(kontener);
                    MasaTeraz += kontener.MasaLadunku;
                }
                else
                {
                    if (counter <= MaxKonteners) --counter;
                    throw new OverfillException("Za duzo kontenerow");
                }
            }
            else
            {
                throw new OverfillException("masa ladunku > niz masa kontenera");
            }
        }
        catch (OverfillException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void UnloadShip(Kontener kontener)
    {
        Container.Remove(kontener);
    }

    public void ChangeContainer(Kontener poprzedni, Kontener nowy)
    {
        int index = Container.IndexOf(poprzedni);
        Container[index] = nowy;
    }

    public void ChangeShip(Kontener kontener, Ship dokad)
    {
        if (Container.Contains(kontener))
        {
            Container.Remove(kontener);
            dokad.Container.Add(kontener);
        }
        else
        {
            Console.WriteLine("Nie ma takiego konteneru in ship");
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Name Ship = {nameShip}, maxPredkosc={MaxPredkosc}, maxKonteners={MaxKonteners}, maxWeight={MaxWeight}");
        sb.AppendLine("Containers:");
        foreach (Kontener kontener in Container)
        {
            sb.AppendLine($"{kontener.NumerSeryjny}, masa ladunku = {kontener.MasaLadunku}, waga wlasna = {kontener.WagaWlasna}");
        }
        return sb.ToString();
    }
}