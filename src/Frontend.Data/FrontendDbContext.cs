using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
