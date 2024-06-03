using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models;

namespace WebApplication1.Configs;

public class PatientEfConfig : IEntityTypeConfiguration<Patient>
{
    public void Configure(EntityTypeBuilder<Patient> builder)
    {
        builder
            .HasKey(k => k.IdPatient)
            .HasName("Patient_pk");

        builder
            .Property(x => x.IdPatient)
            .ValueGeneratedNever();


        builder
            .Property(x => x.FirstName)
            .IsRequired()
            .HasMaxLength(100);
        
        builder
            .Property(x => x.LastName)
            .IsRequired()
            .HasMaxLength(100);

        builder
            .Property(x => x.Birthdate)
            .IsRequired()
            .HasDefaultValueSql("GETUTCDATE()");
        
        //to not have 
        builder.ToTable(nameof(Patient));
        
        
        Patient[] patients =
        {
            new Patient {IdPatient = 1, FirstName = "Emma", LastName = "Johnson", Birthdate = new DateTime(1990, 5, 15)},
            new Patient {IdPatient = 2, FirstName = "Noah", LastName = "Williams", Birthdate = new DateTime(1985, 10, 8)},
            new Patient {IdPatient = 3, FirstName = "Olivia", LastName = "Jones", Birthdate = new DateTime(1982, 3, 22)},
            new Patient {IdPatient = 4, FirstName = "Liam", LastName = "Brown", Birthdate = new DateTime(1995, 7, 12)},
            new Patient {IdPatient = 5, FirstName = "Ava", LastName = "Davis", Birthdate = new DateTime(1988, 12, 30)},
            new Patient {IdPatient = 6, FirstName = "William", LastName = "Miller", Birthdate = new DateTime(1976, 9, 5)},
            new Patient {IdPatient = 7, FirstName = "Isabella", LastName = "Wilson", Birthdate = new DateTime(1992, 2, 18)},
            new Patient {IdPatient = 8, FirstName = "Mason", LastName = "Moore", Birthdate = new DateTime(1980, 11, 25)},
            new Patient {IdPatient = 9, FirstName = "Sophia", LastName = "Taylor", Birthdate = new DateTime(1987, 6, 9)},
            new Patient {IdPatient = 10, FirstName = "Ethan", LastName = "Anderson", Birthdate = new DateTime(1974, 4, 3)},
            new Patient {IdPatient = 11, FirstName = "Amelia", LastName = "Thomas", Birthdate = new DateTime(1998, 8, 14)},
            new Patient {IdPatient = 12, FirstName = "Alexander", LastName = "Jackson", Birthdate = new DateTime(1983, 1, 27)},
            new Patient {IdPatient = 13, FirstName = "Charlotte", LastName = "White", Birthdate = new DateTime(1991, 10, 19)},
            new Patient {IdPatient = 14, FirstName = "Daniel", LastName = "Harris", Birthdate = new DateTime(1979, 7, 6)},
            new Patient {IdPatient = 15, FirstName = "Madison", LastName = "Clark", Birthdate = new DateTime(1989, 4, 11)},
        };

        builder.HasData(patients);
    }
}