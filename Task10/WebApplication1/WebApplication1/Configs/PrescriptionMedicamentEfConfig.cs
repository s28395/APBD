using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models;

namespace WebApplication1.Configs;

public class PrescriptionMedicamentEfConfig : IEntityTypeConfiguration<PrescriptionMedicament>
{
    public void Configure(EntityTypeBuilder<PrescriptionMedicament> builder)
    {
        builder
            .HasKey(x => new { x.IdMedicament, x.IdPrescription })
            .HasName("PrescriptionMedicament_pk");

        builder
            .HasOne(x => x.Prescription)
            .WithMany(x => x.Medicaments)
            .HasForeignKey(x => x.IdPrescription)
            .HasConstraintName("PrescriptionMedicament_Prescription")
            .OnDelete(DeleteBehavior.Restrict);
        
        
        builder
            .HasOne(x => x.Medicament)
            .WithMany(x => x.Prescriptions)
            .HasForeignKey(x => x.IdMedicament)
            .HasConstraintName("PrescriptionMedicament_Medicament")
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .Property(x => x.Dose);

        builder
            .Property(x => x.Details)
            .IsRequired()
            .HasMaxLength(100);

        builder.ToTable(nameof(PrescriptionMedicament));
    }
}