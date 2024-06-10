namespace WebApplication1.Entities;

public class Muzyk
{
    public int IdMuzyk { get; set; }
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public string Pseudonim { get; set; }
    
    
    //dodajemy jezeli podlaczamy do innej tabeli
    public virtual ICollection<WykonawcaUtworu> Utworus { get; set; } = new List<WykonawcaUtworu>();
}