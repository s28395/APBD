namespace WebApplication1.Models;

public class Patient
{
    public int IdPatient { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime Birthdate { get; set; }

    public virtual ICollection<Prescription> Prescrioptions { get; set; } = new List<Prescription>();
}