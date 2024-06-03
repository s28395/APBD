using WebApplication1.Models;

namespace WebApplication1.DTO;

public class PrescriptionRequestDTO
{
    public Patient patient { get; set; }
    public Prescription prescription { get; set; }
    public Doctor doctor { get; set; }
    public List<MedicamentDTO> medicaments { get; set; }
}