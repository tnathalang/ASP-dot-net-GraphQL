using Api.Database;

using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IWebHost host = CreateWebHostBuilder(args).Build();
            using (IServiceScope scope = host.Services.CreateScope())
            {
                ApplicationDbContext context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

                var shapeDbEntry = context.Authors.Add(
                  new Shape
                  {
                      Name = "Rectangle Boxes",
                  }
                );

                context.SaveChanges();

                context.Books.AddRange(
                  new Rectangle
                  {
                      Name = "Rubix",
                      Width = 2,
                      Length = 2,
                      Unit = "Feet",
                      Area = 4,
                      ShapeId = shapeDbEntry.Entity.Id,

                  },
                  new Rectangle
                  {
                      Name = "Huge Rectangle",
                      Width = 8,
                      Length = 10,
                      Unit = "Feet",
                      Area = 80,
                      ShapeId = shapeDbEntry.Entity.Id,
                  }
                );
            }
            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}