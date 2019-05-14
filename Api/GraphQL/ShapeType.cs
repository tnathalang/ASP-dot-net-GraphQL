using Api.Database;
using GraphQL.Types;

namespace Api.GraphQL
{
    public class ShapeType : ObjectGraphType<Shape>
    {
        public ShapeType()
        {
            Name = "Shape";

            Field(x => x.Id, type: typeof(IdGraphType)).Description("Shape's ID.");
            Field(x => x.Name).Description("The name of the Shape");
            Field(x => x.Rectangle, type: typeof(ListGraphType<RectangleType>)).Description("Rectanlges in the Shape");
        }
    }
}