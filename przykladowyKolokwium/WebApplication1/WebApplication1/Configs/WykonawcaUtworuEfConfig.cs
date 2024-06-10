using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Entities;

namespace WebApplication1.Configs;

public class WykonawcaUtworuEfConfig : IEntityTypeConfiguration<WykonawcaUtworu>
{
    public void Configure(EntityTypeBuilder<WykonawcaUtworu> builder)
    {
        builder
            .HasKey(x => new { x.IdMuzyk, x.IdUtwor })
            .HasName("WykonawcaUtworu_pk");

        builder
            .HasOne(x => x.Muzyk)
            .WithMany(x => x.Utworus)
            .HasForeignKey(x => x.IdMuzyk)
            .HasConstraintName("WykonawcaUtworu_Muzyk")
            .OnDelete(DeleteBehavior.Restrict);
        
        builder
            .HasOne(x => x.Utwor)
            .WithMany(x => x.Muzyks)
            .HasForeignKey(x => x.IdUtwor)
            .HasConstraintName("WykonawcaUtworu_Utwor")
            .OnDelete(DeleteBehavior.Restrict);
        
        
        //not to be plural
        builder.ToTable(nameof(WykonawcaUtworu));

        WykonawcaUtworu[] wykonawcaUtworus =
        {
            new WykonawcaUtworu {IdMuzyk = 1,IdUtwor = 1},
            new WykonawcaUtworu {IdMuzyk = 1,IdUtwor = 2},
            new WykonawcaUtworu {IdMuzyk = 1,IdUtwor = 3},
            new WykonawcaUtworu {IdMuzyk = 1,IdUtwor = 4},
            new WykonawcaUtworu {IdMuzyk = 1,IdUtwor = 5},
            new WykonawcaUtworu {IdMuzyk = 2,IdUtwor = 6},
            new WykonawcaUtworu {IdMuzyk = 2,IdUtwor = 7},
            new WykonawcaUtworu {IdMuzyk = 3,IdUtwor = 8},
            new WykonawcaUtworu {IdMuzyk = 3,IdUtwor = 9},
            new WykonawcaUtworu {IdMuzyk = 3,IdUtwor = 10},
        };

        builder.HasData(wykonawcaUtworus);
    }
}