namespace Zad3.Models;

public class Plyny : Kontener, IHazardNotifier
{
    
    
    public Plyny(double masaAll, double wysokosc, double masaKontenera, double glebokosc, string numerSeryjny) : base(masaAll, wysokosc, masaKontenera, glebokosc, numerSeryjny)
    {
        masaA
    }
    
    public void HazardNotifier(string text)
    {
            throw new NotImplementedException();
    }
}