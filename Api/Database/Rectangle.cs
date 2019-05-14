namespace Api.Database
{
    public class Rectangle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }
        public string Unit { get; set; }
        public int Area { get; set; }
        public int ShapeId { get; set; }
        public Shape Shape { get; set; }
    }
}
