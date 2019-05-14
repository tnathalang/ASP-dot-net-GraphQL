
using Microsoft.EntityFrameworkCore;

namespace Api.Database
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
              : base(options)
        { }

        public DbSet<Rectangle> Rectangles { get; set; }
        public DbSet<Shape> Shapes { get; set; }
    }
}