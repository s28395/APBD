using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Entities;

namespace WebApplication1.Configs;

public class MuzykEfConfig : IEntityTypeConfiguration<Muzyk>
{
    public void Configure(EntityTypeBuilder<Muzyk> builder)
    {
        builder
            .HasKey(k => k.IdMuzyk)
            .HasName("Muzyk_pk");

        builder
            .Property(x => x.IdMuzyk)
            .ValueGeneratedNever();

        builder
            .Property(x => x.Imie)
            .IsRequired()
            .HasMaxLength(30);
        
        builder
            .Property(x => x.Nazwisko)
            .IsRequired()
            .HasMaxLength(40);
        
        builder
            .Property(x => x.Pseudonim)
            .HasMaxLength(50);
        
        
        //not to be plural
        builder.ToTable(nameof(Muzyk));


        Muzyk[] muzyks =
        {
            new Muzyk { IdMuzyk = 1, Imie = "Yehor", Nazwisko = "Vasylenko", Pseudonim = "ews" },
            new Muzyk { IdMuzyk = 2, Imie = "Alex", Nazwisko = "Jaronkiewic", Pseudonim = "awic" },
            new Muzyk { IdMuzyk = 3, Imie = "Oliwia", Nazwisko = "Mazur", Pseudonim = "olizur" },
        };

        builder.HasData(muzyks);

    }
}