using Api.Database;
using GraphQL.Types;

namespace Api.GraphQL
{
    public class RectangleType : ObjectGraphType<Rectangle>
    {
        public RectangleType()
        {
            Name = "Rectangle";

            Field(x => x.Id, type: typeof(IdGraphType)).Description("The ID of the Book.");
            Field(x => x.Name).Description("The name of the rectangle");
            Field(x => x.Width).Description("The width of the rectangle");
            Field(x => x.Length).Description("The length of the rectangle");
            Field(x => x.Unit).Description("Rectangle's unit");
            Field(x => x.Area).Description("The area of the Rectangle");
        }
    }
}