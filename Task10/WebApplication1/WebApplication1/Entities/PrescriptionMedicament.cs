namespace WebApplication1.Models;

public class PrescriptionMedicament
{
    public int IdMedicament { get; set; }
    public int IdPrescription { get; set; }
    public int? Dose { get; set; }
    public string Details { get; set; }
    
    //it's for foreign key
    public virtual Medicament Medicament { get; set; }
    public virtual Prescription Prescription { get; set; }
}