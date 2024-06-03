using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models;

namespace WebApplication1.Configs;

public class MedicamentEfConfig : IEntityTypeConfiguration<Medicament>
{
    public void Configure(EntityTypeBuilder<Medicament> builder)
    {
        builder
            .HasKey(k => k.IdMedicament)
            .HasName("Medicament_pk");

        builder
            .Property(x => x.IdMedicament)
            .ValueGeneratedNever();


        builder
            .Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(100);
        
        builder
            .Property(x => x.Description)
            .IsRequired()
            .HasMaxLength(100);
        
        builder
            .Property(x => x.Type)
            .IsRequired()
            .HasMaxLength(100);
        
        //to not have 
        builder.ToTable(nameof(Medicament));
        
        
        Medicament[] medicaments =
        {
            new Medicament {IdMedicament = 1, Name = "Aspirin", Description = "Pain reliever", Type = "Analgesic"},
            new Medicament {IdMedicament = 2, Name = "Amoxicillin", Description = "Antibiotic", Type = "Antibiotic"},
            new Medicament {IdMedicament = 3, Name = "Ibuprofen", Description = "Pain reliever", Type = "Analgesic"},
            new Medicament {IdMedicament = 4, Name = "Acetaminophen", Description = "Pain reliever", Type = "Analgesic"},
            new Medicament {IdMedicament = 5, Name = "Lisinopril", Description = "Blood pressure medication", Type = "Antihypertensive"},
            new Medicament {IdMedicament = 6, Name = "Atorvastatin", Description = "Cholesterol-lowering medication", Type = "Statins"},
            new Medicament {IdMedicament = 7, Name = "Metformin", Description = "Diabetes medication", Type = "Antidiabetic"},
            new Medicament {IdMedicament = 8, Name = "Omeprazole", Description = "Acid reducer", Type = "Proton pump inhibitor"},
            new Medicament {IdMedicament = 9, Name = "Prednisone", Description = "Anti-inflammatory", Type = "Corticosteroid"},
            new Medicament {IdMedicament = 10, Name = "Levothyroxine", Description = "Thyroid hormone replacement", Type = "Thyroid hormone"},
            new Medicament {IdMedicament = 11, Name = "Simvastatin", Description = "Cholesterol-lowering medication", Type = "Statins"},
            new Medicament {IdMedicament = 12, Name = "Albuterol", Description = "Bronchodilator", Type = "Bronchodilator"},
            new Medicament {IdMedicament = 13, Name = "Citalopram", Description = "Antidepressant", Type = "Antidepressant"},
            new Medicament {IdMedicament = 14, Name = "Warfarin", Description = "Blood thinner", Type = "Anticoagulant"},
            new Medicament {IdMedicament = 15, Name = "Furosemide", Description = "Diuretic", Type = "Diuretic"},
        };

        builder.HasData(medicaments);
    }
}