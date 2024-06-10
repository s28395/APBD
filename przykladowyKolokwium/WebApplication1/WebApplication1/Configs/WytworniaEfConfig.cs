using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Entities;

namespace WebApplication1.Configs;

public class WytworniaEfConfig : IEntityTypeConfiguration<Wytwornia>
{
    public void Configure(EntityTypeBuilder<Wytwornia> builder)
    {
        builder
            .HasKey(x => x.IdWytwornia)
            .HasName("Wytwornia_pk");

        builder
            .Property(x => x.IdWytwornia)
            .ValueGeneratedNever();

        builder
            .Property(x => x.Nazwa)
            .IsRequired()
            .HasMaxLength(50);
        
        
        builder.ToTable(nameof(Wytwornia));
    }
}