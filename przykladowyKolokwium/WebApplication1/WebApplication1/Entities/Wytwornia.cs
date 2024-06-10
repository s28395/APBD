namespace WebApplication1.Entities;

public class Wytwornia
{
    public int IdWytwornia { get; set; }
    public string Nazwa { get; set; }

    public virtual ICollection<Album> Albums { get; set; } = new List<Album>();
}