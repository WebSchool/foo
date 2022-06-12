using Microsoft.EntityFrameworkCore;

namespace Frontend.Data;

public class FrontendDbContext : DbContext
{
    public FrontendDbContext(DbContextOptions<FrontendDbContext> options) : base(options)
    {
    }

    public FrontendDbContext()
    {
    }

    public virtual DbSet<Article> Articles { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Article>()
            .HasData(
                new Article { Id = 1, Title = "Статья первая" },
                new Article { Id = 2, Title = "Статья вторая" }
            );

    }
}
