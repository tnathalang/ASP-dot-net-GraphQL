using System.Linq;
using Api.Database;
using GraphQL.Types;
using Microsoft.EntityFrameworkCore;

namespace Api.GraphQL
{
    public class ShapeQuery : ObjectGraphType
    {
        public ShapeQuery(ApplicationDbContext db)
        {
            Field<ShapeType>(
              "Shape",
              arguments: new QueryArguments(
                new QueryArgument<IdGraphType> { Name = "id", Description = "The ID of the Author." }),
              resolve: context =>
              {
                  var id = context.GetArgument<int>("id");
                  var shape = db
              .Shapes
              .Include(a => a.Rectangle)
              .FirstOrDefault(i => i.Id == id);
                  return shape;
              });

            Field<ListGraphType<ShapeType>>(
              "Shapes",
              resolve: context =>
              {
                  var shapes = db.Shapes.Include(a => a.Rectangle);
                  return shapes;
              });
        }
    }
}