using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Entities;

public class UniwersityDbContext : DbContext
{
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Prescription> Prescrioptions { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Medicament> Medicaments { get; set; }
    public DbSet<PrescriptionMedicament> PrescriptionMedicaments { get; set; }
    
    
    
    
    protected UniwersityDbContext()
    {
    }

    public UniwersityDbContext(DbContextOptions options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        //Zeby zaplikowac moje wszstkie pliki konfiguracjyne
        //modelBuilder.ApplyConfigurationsFromAssembly()
        
        modelBuilder.Entity<PrescriptionMedicament>()
           .HasKey(pm => new { pm.IdMedicament, pm.IdPrescription });
        //не дописал, и вообще нужно ли это?
        
        
        modelBuilder.Entity<Prescription>()
            .HasOne(p => p.Patient)
            .WithMany(p => p.Prescrioptions)
            .HasForeignKey(p => p.IdPatient);
        
        
        modelBuilder.Entity<Prescription>()
            .HasOne(p => p.Doctor)
            .WithMany(p => p.Prescrioptions)
            .HasForeignKey(p => p.IdDoctor);
        
    }
}