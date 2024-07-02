
using Data_Base.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data_Base;

public class ProjectDBContext : DbContext
{
    public ProjectDBContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Album> Albums { get; set; } = null!;
    public DbSet<Genre> Genres { get; set; } = null!;
    public DbSet<Singer> Singers { get; set; } = null!;
    public DbSet<Track> Tracks { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=summerProject;Username=postgres;Password=admin");
    }

}
