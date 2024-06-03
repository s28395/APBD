using Microsoft.EntityFrameworkCore;
using WebApplication1.Entities.Configs;

namespace WebApplication1.Entities;

public class UniwersityDbContext : DbContext
{
    //Trzeba dla kazdej tabeli takie zrobic
    //Na wykldazie jest w folderze Context
    public virtual DbSet<Student> Students { get; set; }
    public virtual DbSet<Group> Groups { get; set; }

    public UniwersityDbContext()
    {
        
    }

    public UniwersityDbContext(DbContextOptions<UniwersityDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        //Zeby zaplikowac moje wszystkie pliki konfigurujace
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(GroupEfConfig).Assembly);
    }
}