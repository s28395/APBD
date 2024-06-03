using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Homework.Models;

public class Prescrioption
{
    [Key]
    public int IdPrescription{ get; set; }
    public DateTime Date { get; set; }
    public DateTime DueDate { get; set; }

    public ICollection<Patient> Patients { get; set; } = new List<Patient>();
    
    public int IdPatient { get; set; }
    
    [ForeignKey(nameof(IdPatient))]
    public Patient Patient { get; set; }
    
    public int IdDoctor { get; set; }
    
    [ForeignKey(nameof(IdDoctor))]
    public Doctor Doctor { get; set; }
    
    public ICollection<PrescriptionMedicament> PrescriptionMedicaments { get; set; }
}