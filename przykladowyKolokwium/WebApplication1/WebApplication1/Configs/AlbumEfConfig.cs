using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Entities;

namespace WebApplication1.Configs;

public class AlbumEfConfig : IEntityTypeConfiguration<Album>
{
    public void Configure(EntityTypeBuilder<Album> builder)
    {
        builder
            .HasKey(x => x.IdAlbum)
            .HasName("Album_pk");

        builder
            .Property(x => x.IdAlbum)
            .ValueGeneratedNever();

        builder
            .Property(x => x.NazwaAlbumu)
            .IsRequired()
            .HasMaxLength(30);

        builder
            .Property(x => x.DataWydania)
            .IsRequired()
            .HasDefaultValueSql("GETUTCDATE()");

        builder
            .HasOne(x => x.Wytwornia)
            .WithMany(x => x.Albums)
            .HasForeignKey(x => x.IdWytwornia)
            .HasConstraintName("Album_Wytwornia")
            .OnDelete(DeleteBehavior.Restrict);
        
        //not to be plural
        builder.ToTable(nameof(Album));
    }
}