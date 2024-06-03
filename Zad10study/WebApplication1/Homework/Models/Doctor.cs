using System.ComponentModel.DataAnnotations;

namespace Homework.Models;

public class Doctor
{
    [Key]
    public int IdDoctor { get; set; }
    [MaxLength(100)]
    [Required]
    public string FirstName { get; set; }
    [MaxLength(100)]
    [Required]
    public string LastName { get; set; }
    [MaxLength(100)]
    [Required]
    public string Email { get; set; }
    
    
    public ICollection<Prescrioption> Prescrioptions { get; set; }
}