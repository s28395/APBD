using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Entities;

namespace WebApplication1.Configs;

public class UtworEfConfig : IEntityTypeConfiguration<Utwor>
{
    public void Configure(EntityTypeBuilder<Utwor> builder)
    {
        builder
            .HasKey(x => x.IdUtwor)
            .HasName("Utwor_pk");

        builder
            .Property(x => x.IdUtwor)
            .ValueGeneratedNever();

        builder
            .Property(x => x.NazwaUtworu)
            .IsRequired()
            .HasMaxLength(30);

        builder
            .Property(x => x.CzasTrwania)
            .IsRequired();

        builder
            .HasOne(x => x.Album)
            .WithMany(x => x.Utwors)
            .HasForeignKey(x => x.IdAlbum)
            .HasConstraintName("Utwor_Album")
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Restrict);
        
        //not to be plural
        builder.ToTable(nameof(Utwor));
        
        
        
        Utwor[] utwors =
        {
            new Utwor {IdUtwor = 1,NazwaUtworu = "Pan Tadeusz",CzasTrwania = 999999,IdAlbum = null},
            new Utwor {IdUtwor = 2,NazwaUtworu = "1984",CzasTrwania = 1.5f,IdAlbum = null},
            new Utwor {IdUtwor = 3,NazwaUtworu = "Jane Eir",CzasTrwania = 4,IdAlbum = null},
            new Utwor {IdUtwor = 4,NazwaUtworu = "Harry Potter",CzasTrwania = 14.5f ,IdAlbum = null},
            new Utwor {IdUtwor = 5,NazwaUtworu = "The Ford",CzasTrwania = 7.8f,IdAlbum = null},
            new Utwor {IdUtwor = 6,NazwaUtworu = "The Return",CzasTrwania = 3.4f,IdAlbum = null},
            new Utwor {IdUtwor = 7,NazwaUtworu = "Lord of the rings",CzasTrwania = 2.1f,IdAlbum = null},
            new Utwor {IdUtwor = 8,NazwaUtworu = "Pure and Rich Dad",CzasTrwania = 2.5f,IdAlbum = null},
            new Utwor {IdUtwor = 9,NazwaUtworu = "Pluca Zlepione Topami",CzasTrwania = 7.9f,IdAlbum = null},
            new Utwor {IdUtwor = 10,NazwaUtworu = "Wonderfull Day",CzasTrwania = 12.7f,IdAlbum = null},

        };

        builder.HasData(utwors);
    }
}