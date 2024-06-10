namespace WebApplication1.Entities;

public class WykonawcaUtworu
{
    public int IdMuzyk { get; set; }
    public int IdUtwor { get; set; }
    
    
    //to jest dla foreign key
    public virtual Muzyk Muzyk { get; set; }
    public virtual Utwor Utwor { get; set; }
}