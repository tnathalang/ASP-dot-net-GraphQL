
using Microsoft.EntityFrameworkCore;

namespace Api.Database
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
              : base(options)
        { }

        public DbSet<Rectangle> Books { get; set; }
        public DbSet<Shape> Authors { get; set; }
    }
}