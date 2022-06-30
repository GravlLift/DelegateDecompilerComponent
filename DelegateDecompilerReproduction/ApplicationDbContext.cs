using Microsoft.EntityFrameworkCore;

namespace DeletegateDecompilerRepro
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Game> Games => Set<Game>();
    }
}