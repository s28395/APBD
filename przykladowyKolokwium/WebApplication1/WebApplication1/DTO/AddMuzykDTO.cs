namespace WebApplication1.DTO;

public class AddMuzykDTO
{
    public int IdMuzyk { get; set; }
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public string Pseudonim { get; set; }
    
    
    public int IdUtwor { get; set; }
    public string NazwaUtworu { get; set; }
    public float CzasTrawnia { get; set; }
    //public int? IdAlbum { get; set; }
}