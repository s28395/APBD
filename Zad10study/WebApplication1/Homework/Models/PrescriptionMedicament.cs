using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Homework.Models;

public class PrescriptionMedicament
{
    [Key]
    public int IdMedicament { get; set; }
    
    [Key]
    public int IdPrescription { get; set; }
    
    [ForeignKey(nameof(IdMedicament))]
    public Medicament Medicament { get; set; }
    
    [ForeignKey(nameof(IdPrescription))]
    public Prescrioption Prescrioption { get; set; }
    
    
    
    [Required]
    public int Dose { get; set; }
    [Required]
    [MaxLength(100)]
    public string Details { get; set; }
}