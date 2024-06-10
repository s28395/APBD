namespace WebApplication1.DTO;

public class MuzykDTO
{
    public int IdMuzyk { get; set; }
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public string Pseudonim { get; set; }
    public List<UtworDTO> Utwory { get; set; }
}