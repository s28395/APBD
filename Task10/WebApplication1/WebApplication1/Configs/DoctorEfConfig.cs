using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models;

namespace WebApplication1.Configs;

public class DoctorEfConfig : IEntityTypeConfiguration<Doctor>
{
    public void Configure(EntityTypeBuilder<Doctor> builder)
    {
        builder
            .HasKey(k => k.IdDoctor)
            .HasName("Doctor_pk");

        builder
            .Property(x => x.IdDoctor)
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
            .Property(x => x.Email)
            .IsRequired()
            .HasMaxLength(100);
        
        //to not have plural form
        builder.ToTable(nameof(Doctor));
        
        
        Doctor[] doctors =
        {
            new Doctor {IdDoctor = 1, FirstName = "John", LastName = "Smith", Email = "john.smith@gmail.com"},
            new Doctor {IdDoctor = 2, FirstName = "Emily", LastName = "Johnson", Email = "emily.johnson@gmail.com"},
            new Doctor {IdDoctor = 3, FirstName = "Michael", LastName = "Williams", Email = "michael.williams@gmail.com"},
            new Doctor {IdDoctor = 4, FirstName = "Sarah", LastName = "Jones", Email = "sarah.jones@gmail.com"},
            new Doctor {IdDoctor = 5, FirstName = "James", LastName = "Brown", Email = "james.brown@gmail.com"},
            new Doctor {IdDoctor = 6, FirstName = "Jennifer", LastName = "Davis", Email = "jennifer.davis@gmail.com"},
            new Doctor {IdDoctor = 7, FirstName = "David", LastName = "Miller", Email = "david.miller@gmail.com"},
            new Doctor {IdDoctor = 8, FirstName = "Jessica", LastName = "Wilson", Email = "jessica.wilson@gmail.com"},
            new Doctor {IdDoctor = 9, FirstName = "Matthew", LastName = "Moore", Email = "matthew.moore@gmail.com"},
            new Doctor {IdDoctor = 10, FirstName = "Ashley", LastName = "Taylor", Email = "ashley.taylor@gmail.com"},
            new Doctor {IdDoctor = 11, FirstName = "Christopher", LastName = "Anderson", Email = "christopher.anderson@gmail.com"},
            new Doctor {IdDoctor = 12, FirstName = "Amanda", LastName = "Thomas", Email = "amanda.thomas@gmail.com"},
            new Doctor {IdDoctor = 13, FirstName = "Daniel", LastName = "Jackson", Email = "daniel.jackson@gmail.com"},
            new Doctor {IdDoctor = 14, FirstName = "Brittany", LastName = "White", Email = "brittany.white@gmail.com"},
            new Doctor {IdDoctor = 15, FirstName = "Kevin", LastName = "Harris", Email = "kevin.harris@gmail.com"},
        };

        builder.HasData(doctors);
    }
}