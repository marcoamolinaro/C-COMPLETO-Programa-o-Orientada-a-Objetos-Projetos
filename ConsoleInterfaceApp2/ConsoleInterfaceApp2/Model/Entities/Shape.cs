using ConsoleInterfaceApp2.Model.Enums;

namespace ConsoleInterfaceApp2.Model.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }
        public abstract double Area();
    }
}
