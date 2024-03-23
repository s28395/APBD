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
        MasaTeraz += kontener.MasaLadunku;
        if (Container.Count <= MaxKonteners && MasaTeraz<=MaxWeight)
        {
            Container.Add(kontener);
        }
        else
        {
            throw new Exception("Za duzo kontenerow");
        }
        
    }

    public void UnloadShip(Kontener kontener)
    {
        Container.Remove(kontener);
    }

    public void ChangeContainer(Kontener poprzedni, Kontener nowy)
    {
        poprzedni = nowy;
    }

    public void ChangeShip(Kontener kontener, Ship skad, Ship dokad)
    {
        skad.Container.Remove(kontener);
        dokad.Container.Add(kontener);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Name Ship = {nameShip}, maxPredkosc=${MaxPredkosc}, maxKonteners={MaxKonteners}, maxWeight={MaxWeight}");
        sb.AppendLine("Containers:");
        foreach (Kontener kontener in Container)
        {
            sb.AppendLine($"{kontener.NumerSeryjny}, masa ladunku = {kontener.MasaLadunku}, waga wlasna = {kontener.WagaWlasna}");
        }
        return sb.ToString();
    }
}