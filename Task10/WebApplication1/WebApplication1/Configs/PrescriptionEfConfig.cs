using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models;

namespace WebApplication1.Configs;

public class PrescriptionEfConfig : IEntityTypeConfiguration<Prescription>
{
    public void Configure(EntityTypeBuilder<Prescription> builder)
    {
        builder
            .HasKey(x => x.IdPrescription)
            .HasName("Prescription_pk");

        builder
            .Property(x => x.IdPrescription)
            .ValueGeneratedNever();

        builder
            .Property(x => x.Date)
            .IsRequired()
            .HasDefaultValueSql("GETUTCDATE()");
        
        builder
            .Property(x => x.DueDate)
            .IsRequired()
            .HasDefaultValueSql("GETUTCDATE()");

        builder
            .HasOne(x => x.Patient)
            .WithMany(x => x.Prescrioptions)
            .HasForeignKey(x => x.IdPatient)
            .HasConstraintName("Prescription_Patient")
            .OnDelete(DeleteBehavior.Restrict);
        
        builder
            .HasOne(x => x.Doctor)
            .WithMany(x => x.Prescrioptions)
            .HasForeignKey(x => x.IdDoctor)
            .HasConstraintName("Prescription_Doctor")
            .OnDelete(DeleteBehavior.Restrict);

        builder.ToTable(nameof(Prescription));
    }
}