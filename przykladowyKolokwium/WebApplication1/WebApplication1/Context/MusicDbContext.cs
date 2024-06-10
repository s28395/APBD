using Microsoft.EntityFrameworkCore;
using WebApplication1.Configs;
using WebApplication1.Entities;

namespace WebApplication1.Context;

public class MusicDbContext : DbContext
{
    public virtual DbSet<Muzyk> Muzyks { get; set; }
    public virtual DbSet<Utwor> Utwors { get; set; }
    public virtual DbSet<Album> Albums{ get; set; }
    public virtual DbSet<Wytwornia> Wytwornias { get; set; }
    public virtual DbSet<WykonawcaUtworu> WykonawcaUtworus { get; set; }
    
    
    
    
    public MusicDbContext()
    {
        
    }
    
    public MusicDbContext(DbContextOptions<MusicDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AlbumEfConfig).Assembly);
    }
}