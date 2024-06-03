using Homework.Models;
using Microsoft.EntityFrameworkCore;

namespace Homework.Entities;

public class UniversityDbContext : DbContext
{
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Prescrioption> Prescrioptions { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Medicament> Medicaments { get; set; }
    public DbSet<PrescriptionMedicament> PrescriptionMedicaments { get; set; }
    
    
    
    
    protected UniversityDbContext()
    {
    }

    public UniversityDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<PrescriptionMedicament>()
        //   .HasKey(pm => new { pm.IdMedicament, pm.IdPrescription });
        //не дописал, и вообще нужно ли это?
        
        
    }
}