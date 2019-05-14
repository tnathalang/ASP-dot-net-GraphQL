using System.Collections.Generic;

namespace Api.Database
{
    public class Shape
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Rectangle> Rectangle { get; set; }
    }
}