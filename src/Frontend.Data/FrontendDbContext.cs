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
}
